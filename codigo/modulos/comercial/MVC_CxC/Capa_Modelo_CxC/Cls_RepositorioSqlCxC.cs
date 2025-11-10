using System;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CxC
{
    public class Cls_RepositorioSqlCxC : Cls_IRepositorioCxC
    {
        private readonly Cls_Conexion _cx = new Cls_Conexion();

        // ---------------- FACTURAS ----------------
        public BindingList<FacturaPendiente> ListarFacturas(string clienteLike, DateTime? desde, DateTime? hasta)
        {
            var list = new BindingList<FacturaPendiente>();
            string sql =
@"
SELECT d.Cmp_Id_CxC_Documento, d.Cmp_Fecha_Emision, d.Cmp_Total_Documento, d.Cmp_Saldo_Pendiente,
       c.Cmp_Id_Cliente, c.Cmp_Nombre_Cliente
FROM Tbl_CxC_Documento d
JOIN Tbl_Cliente c ON c.Cmp_Id_Cliente = d.Cmp_Id_Cliente
WHERE d.Cmp_Saldo_Pendiente > 0
  AND (? IS NULL OR c.Cmp_Nombre_Cliente LIKE ?)
  AND (? IS NULL OR d.Cmp_Fecha_Emision >= ?)
  AND (? IS NULL OR d.Cmp_Fecha_Emision <= ?)
ORDER BY d.Cmp_Fecha_Emision DESC, d.Cmp_Id_CxC_Documento DESC;";

            using (OdbcConnection cn = _cx.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, cn))
            {
                if (string.IsNullOrWhiteSpace(clienteLike))
                {
                    cmd.Parameters.Add("pCliNull", OdbcType.VarChar).Value = DBNull.Value;
                    cmd.Parameters.Add("pCliLike", OdbcType.VarChar).Value = "";
                }
                else
                {
                    cmd.Parameters.Add("pCliNull", OdbcType.VarChar).Value = "x"; // NOT NULL
                    cmd.Parameters.Add("pCliLike", OdbcType.VarChar).Value = "%" + clienteLike + "%";
                }

                if (desde.HasValue)
                {
                    cmd.Parameters.Add("pDesdeNull", OdbcType.Date).Value = DateTime.Now; // NOT NULL
                    cmd.Parameters.Add("pDesde", OdbcType.Date).Value = desde.Value.Date;
                }
                else
                {
                    cmd.Parameters.Add("pDesdeNull", OdbcType.Date).Value = DBNull.Value;
                    cmd.Parameters.Add("pDesde", OdbcType.Date).Value = DateTime.Today;
                }

                if (hasta.HasValue)
                {
                    cmd.Parameters.Add("pHastaNull", OdbcType.Date).Value = DateTime.Now; // NOT NULL
                    cmd.Parameters.Add("pHasta", OdbcType.Date).Value = hasta.Value.Date;
                }
                else
                {
                    cmd.Parameters.Add("pHastaNull", OdbcType.Date).Value = DBNull.Value;
                    cmd.Parameters.Add("pHasta", OdbcType.Date).Value = DateTime.Today;
                }

                using (OdbcDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var f = new FacturaPendiente
                        {
                            Id = dr.GetInt32(0),
                            Fecha = dr.GetDate(1),
                            Total = dr.GetDecimal(2),
                            Saldo = dr.GetDecimal(3),
                            IdCliente = dr.GetInt32(4),
                            Cliente = dr.IsDBNull(5) ? "" : dr.GetString(5),
                            Numero = dr.GetInt32(0).ToString() // no hay número → usa Id
                        };
                        list.Add(f);
                    }
                }
            }
            return list;
        }

        // ---------------- RECIBOS ----------------
        public BindingList<Recibo> ListarRecibos()
        {
            var list = new BindingList<Recibo>();
            string sql =
@"SELECT r.Cmp_Id_Recibo, r.Cmp_Fecha_Recibo, r.Cmp_Id_Cliente, c.Cmp_Nombre_Cliente,
         r.Cmp_Total_Recibo, r.Cmp_Observaciones, r.Cmp_Id_Usuario
  FROM Tbl_Recibo r
  JOIN Tbl_Cliente c ON c.Cmp_Id_Cliente = r.Cmp_Id_Cliente
 ORDER BY r.Cmp_Id_Recibo DESC;";

            using (OdbcConnection cn = _cx.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, cn))
            using (OdbcDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var r = new Recibo
                    {
                        Id = dr.GetInt32(0),
                        Fecha = dr.GetDate(1),
                        IdCliente = dr.GetInt32(2),
                        Cliente = dr.IsDBNull(3) ? "" : dr.GetString(3),
                        Monto = dr.GetDecimal(4),
                        Observaciones = dr.IsDBNull(5) ? "" : dr.GetString(5),
                        IdUsuario = dr.IsDBNull(6) ? 0 : dr.GetInt32(6)
                    };
                    list.Add(r);
                }
            }
            return list;
        }

        // Crear Recibo + Detalles + Aplicaciones + Actualizar saldos + Caja (TRANSACCIÓN)
        public Recibo CrearRecibo(Recibo r, LineaPago[] detalles, AplicacionPago[] apps)
        {
            using (OdbcConnection cn = _cx.conexion())
            using (OdbcTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    // 1) Header
                    string insH =
@"INSERT INTO Tbl_Recibo (Cmp_Fecha_Recibo, Cmp_Id_Cliente, Cmp_Total_Recibo, Cmp_Observaciones, Cmp_Id_Usuario)
  VALUES (?,?,?,?,?); SELECT LAST_INSERT_ID();";
                    int newId;
                    using (OdbcCommand cmd = new OdbcCommand(insH, cn, tx))
                    {
                        cmd.Parameters.Add("f", OdbcType.Date).Value = r.Fecha.Date;
                        cmd.Parameters.Add("c", OdbcType.Int).Value = r.IdCliente;
                        cmd.Parameters.Add("t", OdbcType.Decimal).Value = r.Monto;
                        cmd.Parameters.Add("o", OdbcType.VarChar).Value = (object)(r.Observaciones ?? "") ?? DBNull.Value;
                        cmd.Parameters.Add("u", OdbcType.Int).Value = r.IdUsuario;
                        object val = cmd.ExecuteScalar();
                        newId = Convert.ToInt32(val);
                    }

                    // 2) Detalle de métodos de pago
                    if (detalles != null)
                    {
                        string insD = @"INSERT INTO Tbl_Recibo_Det (Cmp_Id_Recibo, Cmp_Id_Metodo_Pago, Cmp_Monto_Pago) VALUES (?,?,?);";
                        using (OdbcCommand cmd = new OdbcCommand(insD, cn, tx))
                        {
                            cmd.Parameters.Add("idrec", OdbcType.Int);
                            cmd.Parameters.Add("met", OdbcType.Int);
                            cmd.Parameters.Add("mon", OdbcType.Decimal);

                            for (int i = 0; i < detalles.Length; i++)
                            {
                                cmd.Parameters["idrec"].Value = newId;
                                cmd.Parameters["met"].Value = detalles[i].IdMetodoPago;
                                cmd.Parameters["mon"].Value = detalles[i].Monto;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 3) Aplicaciones a documentos + actualización de saldo
                    if (apps != null)
                    {
                        string insA = @"INSERT INTO Tbl_Recibo_Aplicacion (Cmp_Id_Recibo, Cmp_Id_CxC_Documento, Cmp_Monto_Aplicado) VALUES (?,?,?);";
                        string updS = @"UPDATE Tbl_CxC_Documento SET Cmp_Saldo_Pendiente = Cmp_Saldo_Pendiente - ? WHERE Cmp_Id_CxC_Documento = ?;";
                        using (OdbcCommand cmdA = new OdbcCommand(insA, cn, tx))
                        using (OdbcCommand cmdS = new OdbcCommand(updS, cn, tx))
                        {
                            cmdA.Parameters.Add("idrec", OdbcType.Int);
                            cmdA.Parameters.Add("iddoc", OdbcType.Int);
                            cmdA.Parameters.Add("monto", OdbcType.Decimal);

                            cmdS.Parameters.Add("monto", OdbcType.Decimal);
                            cmdS.Parameters.Add("iddoc", OdbcType.Int);

                            for (int i = 0; i < apps.Length; i++)
                            {
                                // Insert aplicación
                                cmdA.Parameters["idrec"].Value = newId;
                                cmdA.Parameters["iddoc"].Value = apps[i].IdDocumento;
                                cmdA.Parameters["monto"].Value = apps[i].MontoAplicado;
                                cmdA.ExecuteNonQuery();

                                // Update saldo
                                cmdS.Parameters["monto"].Value = apps[i].MontoAplicado;
                                cmdS.Parameters["iddoc"].Value = apps[i].IdDocumento;
                                cmdS.ExecuteNonQuery();
                            }
                        }
                    }

                    // 4) Caja ingreso (opcional pero recomendado)
                    string insCaja = @"INSERT INTO Tbl_Caja_Ingreso (Cmp_Id_Recibo, Cmp_Fecha_Ingreso, Cmp_Monto_Ingreso) VALUES (?,?,?);";
                    using (OdbcCommand cmd = new OdbcCommand(insCaja, cn, tx))
                    {
                        cmd.Parameters.Add("idrec", OdbcType.Int).Value = newId;
                        cmd.Parameters.Add("fec", OdbcType.Date).Value = r.Fecha.Date;
                        cmd.Parameters.Add("mon", OdbcType.Decimal).Value = r.Monto;
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();

                    r.Id = newId;
                    return r;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public void EditarRecibo(Recibo r)
        {
            string sql = @"UPDATE Tbl_Recibo SET Cmp_Fecha_Recibo=?, Cmp_Observaciones=? WHERE Cmp_Id_Recibo=?;";
            using (OdbcConnection cn = _cx.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, cn))
            {
                cmd.Parameters.Add("f", OdbcType.Date).Value = r.Fecha.Date;
                cmd.Parameters.Add("o", OdbcType.VarChar).Value = (object)(r.Observaciones ?? "") ?? DBNull.Value;
                cmd.Parameters.Add("id", OdbcType.Int).Value = r.Id;
                cmd.ExecuteNonQuery();
            }
        }

        // Anulación simple: (1) revertir saldos aplicados, (2) borrar aplicaciones/detalles, (3) borrar/flag recibo, (4) borrar caja
        public void AnularRecibo(int idRecibo)
        {
            using (OdbcConnection cn = _cx.conexion())
            using (OdbcTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    // 1) Revertir saldos
                    string selApps = @"SELECT Cmp_Id_CxC_Documento, Cmp_Monto_Aplicado FROM Tbl_Recibo_Aplicacion WHERE Cmp_Id_Recibo=?;";
                    using (OdbcCommand cmd = new OdbcCommand(selApps, cn, tx))
                    {
                        cmd.Parameters.Add("id", OdbcType.Int).Value = idRecibo;
                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int idDoc = dr.GetInt32(0);
                                decimal monto = dr.GetDecimal(1);
                                string upd = @"UPDATE Tbl_CxC_Documento SET Cmp_Saldo_Pendiente = Cmp_Saldo_Pendiente + ? WHERE Cmp_Id_CxC_Documento=?;";
                                using (OdbcCommand cmdU = new OdbcCommand(upd, cn, tx))
                                {
                                    cmdU.Parameters.Add("m", OdbcType.Decimal).Value = monto;
                                    cmdU.Parameters.Add("d", OdbcType.Int).Value = idDoc;
                                    cmdU.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    // 2) Borrar hijos
                    ExecNonQ(tx, "DELETE FROM Tbl_Caja_Ingreso       WHERE Cmp_Id_Recibo=?;", idRecibo);
                    ExecNonQ(tx, "DELETE FROM Tbl_Recibo_Aplicacion WHERE Cmp_Id_Recibo=?;", idRecibo);
                    ExecNonQ(tx, "DELETE FROM Tbl_Recibo_Det       WHERE Cmp_Id_Recibo=?;", idRecibo);

                    // 3) Borrar recibo
                    ExecNonQ(tx, "DELETE FROM Tbl_Recibo WHERE Cmp_Id_Recibo=?;", idRecibo);

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private void ExecNonQ(OdbcTransaction tx, string sql, int id)
        {
            using (OdbcCommand cmd = new OdbcCommand(sql, tx.Connection, tx))
            {
                cmd.Parameters.Add("id", OdbcType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }

        // ---------------- REPORTES ----------------
        public DataTable AntiguedadDT(DateTime fechaCorte, int? idCliente)
        {
            const string sql =
@"
SELECT 
  c.Cmp_Nombre_Cliente AS Cliente,
  SUM(CASE WHEN DATEDIFF(?, d.Cmp_Fecha_Emision) BETWEEN 0  AND 30 THEN d.Cmp_Saldo_Pendiente ELSE 0 END) AS `0_30`,
  SUM(CASE WHEN DATEDIFF(?, d.Cmp_Fecha_Emision) BETWEEN 31 AND 60 THEN d.Cmp_Saldo_Pendiente ELSE 0 END) AS `31_60`,
  SUM(CASE WHEN DATEDIFF(?, d.Cmp_Fecha_Emision) BETWEEN 61 AND 90 THEN d.Cmp_Saldo_Pendiente ELSE 0 END) AS `61_90`,
  SUM(CASE WHEN DATEDIFF(?, d.Cmp_Fecha_Emision) > 90 THEN d.Cmp_Saldo_Pendiente ELSE 0 END)               AS `Mas_90`,
  SUM(d.Cmp_Saldo_Pendiente) AS Total
FROM Tbl_CxC_Documento d
JOIN Tbl_Cliente c ON c.Cmp_Id_Cliente = d.Cmp_Id_Cliente
WHERE d.Cmp_Saldo_Pendiente > 0
  AND (? IS NULL OR d.Cmp_Id_Cliente = ?)
GROUP BY c.Cmp_Nombre_Cliente
ORDER BY c.Cmp_Nombre_Cliente;";

            var dt = new DataTable();
            using (OdbcConnection cn = _cx.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, cn))
            using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
            {
                cmd.Parameters.Add("c1", OdbcType.Date).Value = fechaCorte.Date;
                cmd.Parameters.Add("c2", OdbcType.Date).Value = fechaCorte.Date;
                cmd.Parameters.Add("c3", OdbcType.Date).Value = fechaCorte.Date;
                cmd.Parameters.Add("c4", OdbcType.Date).Value = fechaCorte.Date;

                if (idCliente.HasValue)
                { cmd.Parameters.Add("n", OdbcType.Int).Value = idCliente.Value; cmd.Parameters.Add("c", OdbcType.Int).Value = idCliente.Value; }
                else
                { cmd.Parameters.Add("n", OdbcType.Int).Value = DBNull.Value; cmd.Parameters.Add("c", OdbcType.Int).Value = 0; }

                da.Fill(dt);
            }
            return dt;
        }

        public DataTable CajaDiaDT(DateTime fecha, out decimal totalDia)
        {
            const string sql =
@"
SELECT 
  r.Cmp_Id_Recibo     AS Recibo,
  c.Cmp_Nombre_Cliente AS Cliente,
  IFNULL(mp.Cmp_Nombre_Metodo, '-') AS Metodo,
  rd.Cmp_Monto_Pago   AS Monto
FROM Tbl_Recibo r
JOIN Tbl_Cliente c         ON c.Cmp_Id_Cliente = r.Cmp_Id_Cliente
LEFT JOIN Tbl_Recibo_Det rd ON rd.Cmp_Id_Recibo = r.Cmp_Id_Recibo
LEFT JOIN Tbl_Metodo_Pago mp ON mp.Cmp_Id_Metodo_Pago = rd.Cmp_Id_Metodo_Pago
WHERE r.Cmp_Fecha_Recibo = ?
ORDER BY r.Cmp_Id_Recibo;";

            const string sqlTot =
@"SELECT COALESCE(SUM(rd.Cmp_Monto_Pago),0) FROM Tbl_Recibo r
  LEFT JOIN Tbl_Recibo_Det rd ON rd.Cmp_Id_Recibo = r.Cmp_Id_Recibo
 WHERE r.Cmp_Fecha_Recibo = ?;";

            var dt = new DataTable();
            totalDia = 0m;

            using (OdbcConnection cn = _cx.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, cn))
                {
                    cmd.Parameters.Add("f", OdbcType.Date).Value = fecha.Date;
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        da.Fill(dt);
                }

                using (OdbcCommand cmd = new OdbcCommand(sqlTot, cn))
                {
                    cmd.Parameters.Add("f", OdbcType.Date).Value = fecha.Date;
                    object v = cmd.ExecuteScalar();
                    if (v != null && v != DBNull.Value) totalDia = Convert.ToDecimal(v);
                }
            }
            return dt;
        }

        // ---------------- COMBOS ----------------
        public DataTable ClientesDT()
        {
            var dt = new DataTable();
            using (OdbcConnection cn = _cx.conexion())
            using (OdbcDataAdapter da = new OdbcDataAdapter(
                "SELECT Cmp_Id_Cliente, Cmp_Nombre_Cliente FROM Tbl_Cliente ORDER BY Cmp_Nombre_Cliente;", cn))
                da.Fill(dt);
            return dt;
        }
    }
}

/// Autor: Arón Ricardo Esquit Silva    0901-22-13036
// Fecha: 12/09/2025
using System;
using System.Data;
using System.Net;

namespace CapaModelo
{
    public class Cls_SentenciasBitacora
    {
        private readonly Cls_BitacoraDao dao = new Cls_BitacoraDao();

        private string ObtenerIP()
        {
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private string ObtenerNombrePc()
        {
            return Environment.MachineName;
        }

        private string FechaActual()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // -------------------- CONSULTAS --------------------

        public DataTable Listar()
        {
            string sSql = @"
                SELECT  b.pk_id_bitacora        AS id,
                        COALESCE(u.nombre_usuario,'')    AS usuario,
                        COALESCE(a.nombre_aplicacion,'') AS aplicacion,
                        COALESCE(t.nombre_tabla,'')      AS tabla,
                        b.fecha_bitacora        AS fecha,
                        b.accion_bitacora       AS accion,
                        b.ip_bitacora           AS ip,
                        b.nombre_pc_bitacora    AS equipo,
                        CASE b.login_estado_bitacora
                             WHEN 1 THEN 'Conectado'
                             ELSE 'Desconectado'
                        END AS estado
                FROM tbl_BITACORA b
                LEFT JOIN tbl_USUARIO u    ON u.pk_id_usuario = b.fk_id_usuario
                LEFT JOIN tbl_APLICACION a ON a.pk_id_aplicacion = b.fk_id_aplicacion
                LEFT JOIN tbl_LISTA_TABLAS t ON t.pk_id_lista_tabla = b.fk_id_lista_tabla
                ORDER BY b.fecha_bitacora DESC, b.pk_id_bitacora DESC;";

            return dao.EjecutarConsulta(sSql);
        }

        public DataTable ConsultarPorFecha(DateTime fecha)
        {
            string sSql = $@"
                SELECT  b.pk_id_bitacora AS id,
                        u.nombre_usuario AS usuario,
                        a.nombre_aplicacion AS aplicacion,
                        t.nombre_tabla    AS tabla,
                        b.fecha_bitacora  AS fecha,
                        b.accion_bitacora AS accion,
                        b.ip_bitacora     AS ip,
                        b.nombre_pc_bitacora AS equipo,
                        CASE b.login_estado_bitacora
                             WHEN 1 THEN 'Conectado'
                             ELSE 'Desconectado'
                        END AS estado
                FROM tbl_BITACORA b
                LEFT JOIN tbl_USUARIO u    ON u.pk_id_usuario = b.fk_id_usuario
                LEFT JOIN tbl_APLICACION a ON a.pk_id_aplicacion = b.fk_id_aplicacion
                LEFT JOIN tbl_LISTA_TABLAS t ON t.pk_id_lista_tabla = b.fk_id_lista_tabla
                WHERE DATE(b.fecha_bitacora) = '{fecha:yyyy-MM-dd}'
                ORDER BY b.fecha_bitacora DESC;";

            return dao.EjecutarConsulta(sSql);
        }

        public DataTable ConsultarPorRango(DateTime inicio, DateTime fin)
        {
            string sSql = $@"
                SELECT  b.pk_id_bitacora AS id,
                        u.nombre_usuario AS usuario,
                        a.nombre_aplicacion AS aplicacion,
                        t.nombre_tabla    AS tabla,
                        b.fecha_bitacora  AS fecha,
                        b.accion_bitacora AS accion,
                        b.ip_bitacora     AS ip,
                        b.nombre_pc_bitacora AS equipo,
                        CASE b.login_estado_bitacora
                             WHEN 1 THEN 'Conectado'
                             ELSE 'Desconectado'
                        END AS estado
                FROM tbl_BITACORA b
                LEFT JOIN tbl_USUARIO u    ON u.pk_id_usuario = b.fk_id_usuario
                LEFT JOIN tbl_APLICACION a ON a.pk_id_aplicacion = b.fk_id_aplicacion
                LEFT JOIN tbl_LISTA_TABLAS t ON t.pk_id_lista_tabla = b.fk_id_lista_tabla
                WHERE b.fecha_bitacora BETWEEN '{inicio:yyyy-MM-dd}' AND '{fin:yyyy-MM-dd}'
                ORDER BY b.fecha_bitacora DESC;";

            return dao.EjecutarConsulta(sSql);
        }

        public DataTable ConsultarPorUsuario(int idUsuario)
        {
            string sSql = $@"
                SELECT  b.pk_id_bitacora AS id,
                        u.nombre_usuario AS usuario,
                        a.nombre_aplicacion AS aplicacion,
                        t.nombre_tabla    AS tabla,
                        b.fecha_bitacora  AS fecha,
                        b.accion_bitacora AS accion,
                        b.ip_bitacora     AS ip,
                        b.nombre_pc_bitacora AS equipo,
                        CASE b.login_estado_bitacora
                             WHEN 1 THEN 'Conectado'
                             ELSE 'Desconectado'
                        END AS estado
                FROM tbl_BITACORA b
                LEFT JOIN tbl_USUARIO u    ON u.pk_id_usuario = b.fk_id_usuario
                LEFT JOIN tbl_APLICACION a ON a.pk_id_aplicacion = b.fk_id_aplicacion
                LEFT JOIN tbl_LISTA_TABLAS t ON t.pk_id_lista_tabla = b.fk_id_lista_tabla
                WHERE b.fk_id_usuario = {idUsuario}
                ORDER BY b.fecha_bitacora DESC;";

            return dao.EjecutarConsulta(sSql);
        }

        // -------------------- INSERCIONES --------------------

        public void InsertarBitacora(int idUsuario, int idAplicacion, int? idListaTabla, string accion, bool estadoLogin = false)
        {
            string idTabla = idListaTabla.HasValue ? idListaTabla.Value.ToString() : "NULL";

            string sSql = $@"
                INSERT INTO tbl_BITACORA
                (fk_id_usuario, fk_id_aplicacion, fk_id_lista_tabla, fecha_bitacora, accion_bitacora, ip_bitacora, nombre_pc_bitacora, login_estado_bitacora)
                VALUES ({idUsuario}, {idAplicacion}, {idTabla}, '{FechaActual()}', '{accion}', '{ObtenerIP()}', '{ObtenerNombrePc()}', {(estadoLogin ? 1 : 0)})";

            dao.EjecutarConsulta(sSql);
        }



        public void RegistrarInicioSesion(int idUsuario, int? idListaTabla)
        {
            Cls_UsuarioConectado.IniciarSesion(idUsuario, "nombre_usuario");
            InsertarBitacora(idUsuario, null, idListaTabla, "Conectado", Cls_UsuarioConectado.bLoginEstado);
        }

        public void RegistrarCierreSesion(int idUsuario, int? idListaTabla)
        {
            InsertarBitacora(idUsuario, null, idListaTabla, "Desconectado", false);
            Cls_UsuarioConectado.CerrarSesion();
        }

        // Maestro (acepta null en app y tabla)
        public void InsertarBitacora(int idUsuario, int? idAplicacion, int? idListaTabla,
                                     string accion, bool estadoLogin)
        {
            string idApp = idAplicacion.HasValue ? idAplicacion.Value.ToString() : "NULL";
            string idTabla = idListaTabla.HasValue ? idListaTabla.Value.ToString() : "NULL";

            string sSql = $@"
      INSERT INTO tbl_BITACORA
        (fk_id_usuario, fk_id_aplicacion, fk_id_lista_tabla, fecha_bitacora,
         accion_bitacora, ip_bitacora, nombre_pc_bitacora, login_estado_bitacora)
      VALUES
        ({idUsuario}, {idApp}, {idTabla}, '{FechaActual()}',
         '{accion}', '{ObtenerIP()}', '{ObtenerNombrePc()}', {(estadoLogin ? 1 : 0)});";

            dao.EjecutarConsulta(sSql);
        }

        // Compatibilidad (antiguo con 4 params)
        public void InsertarBitacora(int idUsuario, int? idAplicacion,
                                     string accion, bool estadoLogin) =>
            InsertarBitacora(idUsuario, idAplicacion, null, accion, estadoLogin);

        // Solo usuario (sin app ni tabla)
        public void InsertarBitacora(int idUsuario,
                                     string accion, bool estadoLogin) =>
            InsertarBitacora(idUsuario, null, null, accion, estadoLogin);

        // Login / logout aceptando null
        public void RegistrarInicioSesion(int idUsuario, int? idAplicacion = null, int? idListaTabla = null)
            => InsertarBitacora(idUsuario, idAplicacion, idListaTabla, "Conectado", true);

        public void RegistrarCierreSesion(int idUsuario, int? idAplicacion = null, int? idListaTabla = null)
            => InsertarBitacora(idUsuario, idAplicacion, idListaTabla, "Desconectado", false);

    }
}

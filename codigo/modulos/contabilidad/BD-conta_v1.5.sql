CREATE DATABASE Bd_Hoteleria CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE Bd_Hoteleria;
-- Tablas para el Modulo de Contabilidad

-- Tablas para el Modulo de Contabilidad
CREATE TABLE Tbl_Catalogo_Cuentas (
    Pk_Codigo_Cuenta VARCHAR(20) PRIMARY KEY, -- Para que se pueda ingresar como 1.1, 1.2 etc
    Cmp_CtaNombre VARCHAR(100) NOT NULL,
    Cmp_CtaMadre VARCHAR(20) NULL,
    Cmp_CtaSaldoInicial DECIMAL(15,2) DEFAULT 0,
    Cmp_CtaCargoMes DECIMAL(15,2) DEFAULT 0,
    Cmp_CtaAbonoMes DECIMAL(15,2) DEFAULT 0,
    Cmp_CtaSaldoActual DECIMAL(15,2) DEFAULT 0,
    Cmp_CtaCargoActual DECIMAL(15,2) DEFAULT 0,
    Cmp_CtaAbonoActual DECIMAL(15,2) DEFAULT 0,
    Cmp_CtaTipo BIT NOT NULL, -- 0 Mayor y 1 Detalle. Si es cuenta mayor, como "Activo" o cuenta detalle, como "Caja contable", para polizas
    Cmp_CtaNaturaleza BIT NOT NULL, -- Naturaleza contable, si es 0 Acreedor y 1 Deudor

    CONSTRAINT Fk_CtaMadre 
        FOREIGN KEY (Cmp_CtaMadre)
        REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE -- Si una cuenta madre se actualiza, las hijas se actualizan
        ON DELETE RESTRICT -- No se puede eliminar una cuenta madre si tiene hijas con algún saldo
);
INSERT INTO Tbl_Catalogo_Cuentas 
(Pk_Codigo_Cuenta, Cmp_CtaNombre, Cmp_CtaMadre, Cmp_CtaSaldoActual, Cmp_CtaTipo, Cmp_CtaNaturaleza)
VALUES
-- ACTIVO
('1', 'ACTIVO', NULL, 0, 0, 1),
('1.1', 'Activo disponible', '1', 0, 0, 1),
('1.1.1', 'Caja general', '1.1', 600, 1, 1),
('1.1.2', 'Caja chica', '1.1', 400, 1, 1),
('1.2', 'Bancos', '1', 0, 0, 1),
('1.2.1', 'Banco G&T', '1.2', 700, 1, 1),
('1.2.2', 'Banco BI', '1.2', 500, 1, 1),
('1.3', 'Cuentas por cobrar', '1', 0, 0, 1),
('1.3.1', 'Clientes nacionales', '1.3', 1200, 1, 1),
('1.3.2', 'Clientes extranjeros', '1.3', 800, 1, 1),
('1.4', 'Inventarios', '1', 0, 0, 1),
('1.4.1', 'Mercadería', '1.4', 3000, 1, 1),
('1.4.2', 'Materia prima', '1.4', 1500, 1, 1),
('1.5', 'Activos fijos', '1', 0, 0, 1),
('1.5.1', 'Mobiliario y equipo', '1.5', 4000, 1, 1),
('1.5.2', 'Equipo de cómputo', '1.5', 2500, 1, 1),
('1.5.3', 'Vehículos', '1.5', 3500, 1, 1),
-- depreciacion cuentas
('1.6', 'Depreciaciones acumuladas', '1', 0, 0, 0),
('1.6.1', 'Dep. acumulada mobiliario y equipo', '1.6', 0, 1, 0),
('1.6.2', 'Dep. acumulada equipo de cómputo', '1.6', 0, 1, 0),
('1.6.3', 'Dep. acumulada vehículos', '1.6', 0, 1, 0),

-- PASIVO
('2', 'PASIVO', NULL, 0, 0, 0),
('2.1', 'Cuentas por pagar', '2', 0, 0, 0),
('2.1.1', 'Proveedores locales', '2.1', 1500, 1, 0),
('2.1.2', 'Proveedores extranjeros', '2.1', 1000, 1, 0),
('2.2', 'Obligaciones bancarias', '2', 0, 0, 0),
('2.2.1', 'Préstamo Banco G&T', '2.2', 2000, 1, 0),
('2.2.2', 'Préstamo Banco BI', '2.2', 1500, 1, 0),
('2.3', 'Impuestos por pagar', '2', 0, 0, 0),
('2.3.1', 'IVA por pagar', '2.3', 800, 1, 0),
('2.3.2', 'ISR por pagar', '2.3', 1200, 1, 0),
('2.3.3', 'Retenciones por pagar', '2.3', 300, 1, 0),
('2.3.4', 'IGSS por pagar', '2.3', 500, 1, 0),
('2.4', 'Otras obligaciones', '2', 0, 0, 0),
('2.4.1', 'Acreedores varios', '2.4', 400, 1, 0),

-- CAPITAL
('3', 'CAPITAL', NULL, 0, 0, 0),
('3.1', 'Capital social', '3', 3000, 1, 0),
('3.2', 'Utilidades retenidas', '3', 0, 0, 0),
('3.2.1', 'Ejercicio anterior', '3.2', 2000, 1, 0),
('3.2.2', 'Ejercicio actual', '3.2', 0, 1, 0),

-- INGRESOS
('4', 'INGRESOS', NULL, 0, 0, 0),
('4.1', 'Ventas', '4', 0, 0, 0),
('4.1.1', 'Ventas nacionales', '4.1', 25000, 1, 0),
('4.1.2', 'Ventas exportación', '4.1', 8000, 1, 0),
('4.2', 'Otros ingresos', '4', 0, 0, 0),
('4.2.1', 'Descuentos obtenidos', '4.2', 500, 1, 0),
('4.2.2', 'Intereses ganados', '4.2', 300, 1, 0),
('4.3', 'Devoluciones sobre compras', '4', 200, 1, 0),

-- COSTOS
('5', 'COSTOS', NULL, 0, 0, 1),
('5.1', 'Costos operativos', '5', 0, 0, 1),
('5.1.1', 'Costo de ventas', '5.1', 18000, 1, 1),
('5.1.2', 'Transporte de mercadería', '5.1', 1200, 1, 1),
('5.2', 'Costos de producción', '5', 0, 0, 1),
('5.2.1', 'Materia prima consumida', '5.2', 2800, 1, 1),
('5.2.2', 'Mano de obra directa', '5.2', 4000, 1, 1),

-- GASTOS
('6', 'GASTOS', NULL, 0, 0, 1),
('6.1', 'Gastos operativos', '6', 0, 0, 1),
('6.1.1', 'Sueldos administrativos', '6.1', 3000, 1, 1),
('6.1.2', 'Energía eléctrica', '6.1', 900, 1, 1),
('6.1.3', 'Papelería y útiles', '6.1', 600, 1, 1),
('6.1.4', 'Publicidad', '6.1', 1200, 1, 1),
('6.1.5', 'Gastos de depreciacion', '6.1', 0, 1, 1),-- depreciacion
('6.2', 'Gastos financieros', '6', 0, 0, 1),
('6.2.1', 'Intereses bancarios', '6.2', 800, 1, 1),
('6.3', 'Gasto por impuesto ISR', '6', 1200, 1, 1);

-- =============================================
-- TABLA: Activos Fijos (CON GRUPO INCLUIDO)
-- =============================================
CREATE TABLE Tbl_ActivosFijos (
    Pk_Activo_ID INT AUTO_INCREMENT PRIMARY KEY,
    Cmp_Nombre_Activo VARCHAR(100) NOT NULL,
    Cmp_Descripcion VARCHAR(200),
    Cmp_Grupo_Activo VARCHAR(50) NOT NULL DEFAULT 'Otros', -- Campo grupos
    Cmp_Fecha_Adquisicion DATE NOT NULL,
    Cmp_Costo_Adquisicion DECIMAL(15,2) NOT NULL,
    Cmp_Valor_Residual DECIMAL(15,2) NOT NULL,
    Cmp_Vida_Util INT NOT NULL,
    Cmp_Estado BIT NOT NULL DEFAULT 1,
    Cmp_CtaActivo VARCHAR(20),
    Cmp_CtaDepreciacion VARCHAR(20),
    Cmp_CtaGastoDepreciacion VARCHAR(20),
    
    FOREIGN KEY (Cmp_CtaActivo) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta),
    FOREIGN KEY (Cmp_CtaDepreciacion) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta),
    FOREIGN KEY (Cmp_CtaGastoDepreciacion) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
);
-- =============================================
-- TABLA: Depreciación Calculada
-- =============================================
CREATE TABLE Tbl_DepreciacionActivos (
    Pk_Depreciacion_ID INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Activo_ID INT NOT NULL,
    Cmp_Anio INT NOT NULL,
    Cmp_Valor_En_Libros DECIMAL(15,2) NOT NULL,
    Cmp_Depreciacion_Anual DECIMAL(15,2) NOT NULL,
    Cmp_Depreciacion_Acumulada DECIMAL(15,2) NOT NULL,
    
    FOREIGN KEY (Fk_Activo_ID) REFERENCES Tbl_ActivosFijos(Pk_Activo_ID)
);


-- Tabla para encabezado de Poliza
CREATE TABLE Tbl_EncabezadoPoliza (
    Pk_EncCodigo_Poliza INT NOT NULL,
    Pk_Fecha_Poliza DATE NOT NULL,
    Cmp_Concepto_Poliza VARCHAR(200) NOT NULL,
    Cmp_Valor_Poliza DECIMAL(15,2) DEFAULT 0,
    Cmp_Estado_Poliza TINYINT NOT NULL DEFAULT 1, -- 0 Inactivo, 1 Activo y 2 Actualizado
    PRIMARY KEY (Pk_EncCodigo_Poliza, Pk_Fecha_Poliza)
);

-- Tabla para Detalle de Poliza
CREATE TABLE Tbl_DetallePoliza (
    PkFk_EncCodigo_Poliza INT NOT NULL,
    PkFk_Fecha_Poliza DATE NOT NULL,
    PkFk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Tipo_Poliza BIT NOT NULL, -- 1 = Cargo, 0 = Abono
    Cmp_Valor_Poliza DECIMAL(15,2) NOT NULL CHECK (Cmp_Valor_Poliza >= 0),

    PRIMARY KEY (PkFk_EncCodigo_Poliza, PkFk_Fecha_Poliza, PkFk_Codigo_Cuenta),

    CONSTRAINT fk_detalle_poliza_encabezado
        FOREIGN KEY (PkFk_EncCodigo_Poliza, PkFk_Fecha_Poliza)
        REFERENCES Tbl_EncabezadoPoliza(Pk_EncCodigo_Poliza, Pk_Fecha_Poliza)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    CONSTRAINT fk_detalle_poliza_cuenta
        FOREIGN KEY (PkFk_Codigo_Cuenta)
        REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);
-- Periodos contables para control
CREATE TABLE Tbl_PeriodosContables (
    Pk_Id_Periodo INT AUTO_INCREMENT PRIMARY KEY,
    Cmp_Anio INT NOT NULL,
    Cmp_Mes TINYINT NULL, -- NULL cuando el cierre es anual
    Cmp_FechaInicio DATE NOT NULL,
    Cmp_FechaFin DATE NOT NULL,
    Cmp_Estado TINYINT(1) NOT NULL DEFAULT 1, -- 1 activo, 0 inactivo
    Cmp_ModoActualizacion TINYINT(1) NOT NULL DEFAULT 0, -- 0 Batch, 1 En Línea

    CONSTRAINT Uk_Periodo UNIQUE (Cmp_Anio, Cmp_Mes)
);
INSERT INTO Tbl_PeriodosContables
(Cmp_Anio, Cmp_Mes, Cmp_FechaInicio, Cmp_FechaFin, Cmp_Estado, Cmp_ModoActualizacion)
VALUES
(2025, 7,  '2025-07-01', '2025-07-31', 0, 0),
(2025, 8,  '2025-08-01', '2025-08-31', 0, 1),
(2025, 9,  '2025-09-01', '2025-09-30', 0, 0),
(2025, 10, '2025-10-01', '2025-10-31', 0, 1),
(2025, 11, '2025-11-01', '2025-11-30', 1, 0); 



-- Mostrar consulta recursiva para ver salto total cuenta madre
WITH RECURSIVE JerarquiaCuentas AS (
    -- se empieza desde la cuenta madre
    SELECT 
        Pk_Codigo_Cuenta,
        Cmp_CtaNombre,
        Cmp_CtaMadre,
        Cmp_CtaSaldoActual
    FROM Tbl_Catalogo_Cuentas
    WHERE Pk_Codigo_Cuenta = '1'  -- La cuenta madre raíz

    UNION ALL

    -- Se traen todas las hijas de cada cuenta encontrada
    SELECT 
        h.Pk_Codigo_Cuenta,
        h.Cmp_CtaNombre,
        h.Cmp_CtaMadre,
        h.Cmp_CtaSaldoActual
    FROM Tbl_Catalogo_Cuentas h
    INNER JOIN JerarquiaCuentas j ON h.Cmp_CtaMadre = j.Pk_Codigo_Cuenta
)

-- se muestran todas las cuentas relacionadas
SELECT 
    Pk_Codigo_Cuenta,
    Cmp_CtaNombre,
    Cmp_CtaMadre,
    Cmp_CtaSaldoActual,
    (SELECT SUM(Cmp_CtaSaldoActual) FROM JerarquiaCuentas) AS Total_Saldo_Grupo
FROM JerarquiaCuentas;

-- Muestra el saldo acomulado por nodos
WITH RECURSIVE CuentasJerarquia AS (
    SELECT 
        c.Pk_Codigo_Cuenta,
        c.Cmp_CtaNombre,
        c.Cmp_CtaMadre,
        c.Cmp_CtaSaldoActual
    FROM Tbl_Catalogo_Cuentas c
    
    UNION ALL
    
    SELECT 
        h.Pk_Codigo_Cuenta,
        h.Cmp_CtaNombre,
        h.Cmp_CtaMadre,
        h.Cmp_CtaSaldoActual
    FROM Tbl_Catalogo_Cuentas h
    INNER JOIN CuentasJerarquia cj 
        ON h.Cmp_CtaMadre = cj.Pk_Codigo_Cuenta
),
SaldosJerarquicos AS (
    SELECT 
        c1.Pk_Codigo_Cuenta,
        COALESCE(SUM(c2.Cmp_CtaSaldoActual), 0) AS Saldo_Acumulado
    FROM Tbl_Catalogo_Cuentas c1
    LEFT JOIN Tbl_Catalogo_Cuentas c2
        ON c2.Pk_Codigo_Cuenta LIKE CONCAT(c1.Pk_Codigo_Cuenta, '%')
    GROUP BY c1.Pk_Codigo_Cuenta
)
SELECT 
    c.Pk_Codigo_Cuenta,
    c.Cmp_CtaNombre,
    s.Saldo_Acumulado
FROM Tbl_Catalogo_Cuentas c
JOIN SaldosJerarquicos s ON c.Pk_Codigo_Cuenta = s.Pk_Codigo_Cuenta
ORDER BY c.Pk_Codigo_Cuenta;


-- ------------------------------------------------------- Estados Financieros------------------------------------------------------- 
-- -------------------------------------------------Aron Ricardo Esuqit Silva 0901-22-13036 -------------------------------------
CREATE TABLE Tbl_Balance_Saldos (
    Pk_Id_Balance INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Debe DECIMAL(15,2) DEFAULT 0,
    Cmp_Haber DECIMAL(15,2) DEFAULT 0,
    Cmp_Saldo DECIMAL(15,2) DEFAULT 0,
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

CREATE TABLE Tbl_Estado_Resultados (
    Pk_Id_Estado INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Tipo_Cuenta VARCHAR(50) NOT NULL,  -- Ingreso, Costo o Gasto
    Cmp_Valor DECIMAL(15,2) DEFAULT 0,
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

CREATE TABLE Tbl_Balance_General (
    Pk_Id_BalanceGeneral INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Tipo_Cuenta VARCHAR(50) NOT NULL,   -- Activo, Pasivo o Capital
    Cmp_Valor DECIMAL(15,2) DEFAULT 0,
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);


CREATE TABLE Tbl_Flujo_Efectivo (
    Pk_Id_Flujo INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Tipo_Actividad VARCHAR(50) NOT NULL,   -- Operativa, Inversión o Financiación
    Cmp_Entrada DECIMAL(15,2) DEFAULT 0,
    Cmp_Salida DECIMAL(15,2) DEFAULT 0,
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

 -- -----------------------------------------------------------------Reportes-----------------------------------------------------------------
-- REPORTE BALANCE DE SALDOS
CREATE TABLE Tbl_Reporte_Balance_Saldos (
    Pk_Id_Reporte INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Balance INT,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Debe DECIMAL(15,2) DEFAULT 0,
    Cmp_Haber DECIMAL(15,2) DEFAULT 0,
    Cmp_Saldo DECIMAL(15,2) DEFAULT 0,
    Cmp_Fecha_Reporte DATETIME DEFAULT NOW(),
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT,
    FOREIGN KEY (Fk_Id_Balance) REFERENCES Tbl_Balance_Saldos(Pk_Id_Balance)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

--  REPORTE ESTADO DE RESULTADOS
CREATE TABLE Tbl_Reporte_Estado_Resultados (
    Pk_Id_Reporte INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Estado INT,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Tipo_Cuenta VARCHAR(50) NOT NULL,  -- Ingreso, Costo o Gasto
    Cmp_Valor DECIMAL(15,2) DEFAULT 0,
    Cmp_Fecha_Reporte DATETIME DEFAULT NOW(),
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT,
    FOREIGN KEY (Fk_Id_Estado) REFERENCES Tbl_Estado_Resultados(Pk_Id_Estado)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

--  REPORTE BALANCE GENERAL
CREATE TABLE Tbl_Reporte_Balance_General (
    Pk_Id_Reporte INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_BalanceGeneral INT,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Tipo_Cuenta VARCHAR(50) NOT NULL,   -- Activo, Pasivo o Capital
    Cmp_Valor DECIMAL(15,2) DEFAULT 0,
    Cmp_Fecha_Reporte DATETIME DEFAULT NOW(),
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT,
    FOREIGN KEY (Fk_Id_BalanceGeneral) REFERENCES Tbl_Balance_General(Pk_Id_BalanceGeneral)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

--  REPORTE FLUJO DE EFECTIVO
CREATE TABLE Tbl_Reporte_Flujo_Efectivo (
    Pk_Id_Reporte INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Flujo INT,
    Fk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_Nombre_Cuenta VARCHAR(100) NOT NULL,
    Cmp_Tipo_Actividad VARCHAR(50) NOT NULL,   -- Operativa, Inversión o Financiación
    Cmp_Entrada DECIMAL(15,2) DEFAULT 0,
    Cmp_Salida DECIMAL(15,2) DEFAULT 0,
    Cmp_Fecha_Reporte DATETIME DEFAULT NOW(),
    FOREIGN KEY (Fk_Codigo_Cuenta) REFERENCES Tbl_Catalogo_Cuentas(Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT,
    FOREIGN KEY (Fk_Id_Flujo) REFERENCES Tbl_Flujo_Efectivo(Pk_Id_Flujo)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- ----------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tbl_historico_catalogo_cuentas (
    Cmp_Anio INT NOT NULL,
    Cmp_Mes TINYINT NOT NULL,
    Pk_Codigo_Cuenta VARCHAR(20) NOT NULL,
    Cmp_CtaNombre VARCHAR(100) NOT NULL,
    Cmp_CtaMadre VARCHAR(20) NULL DEFAULT NULL,
    Cmp_CtaSaldoInicial DECIMAL(15,2) NOT NULL DEFAULT 0.00,
    Cmp_CtaCargoMes DECIMAL(15,2) NOT NULL DEFAULT 0.00,
    Cmp_CtaAbonoMes DECIMAL(15,2) NOT NULL DEFAULT 0.00,
    Cmp_CtaSaldoActual DECIMAL(15,2) NOT NULL DEFAULT 0.00,
    Cmp_CtaCargoActual DECIMAL(15,2) NOT NULL DEFAULT 0.00,
    Cmp_CtaAbonoActual DECIMAL(15,2) NOT NULL DEFAULT 0.00,
    Cmp_CtaTipo BIT(1) NOT NULL,
    
    Cmp_CtaNaturaleza BIT(1) NOT NULL,

    PRIMARY KEY (Cmp_Anio,Cmp_Mes, Pk_Codigo_Cuenta) USING BTREE,

    INDEX Idx_Historico_Cuenta (Pk_Codigo_Cuenta) USING BTREE,

    CONSTRAINT Fk_Historico_Cuenta
        FOREIGN KEY (Pk_Codigo_Cuenta)
        REFERENCES tbl_catalogo_cuentas (Pk_Codigo_Cuenta)
        ON UPDATE CASCADE
        ON DELETE RESTRICT,

    CONSTRAINT Fk_Historico_Periodo
        FOREIGN KEY (Cmp_Anio, Cmp_Mes)
        REFERENCES tbl_periodoscontables (Cmp_Anio, Cmp_Mes)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

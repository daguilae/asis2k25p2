-- ==========================================================
-- Script de Base de Datos - Sistema de Nómina
-- Autor: Fredy Reyes
-- Carné: 0901-22-9800
-- Fecha: 15 de octubre de 2025
-- ==========================================================

CREATE DATABASE IF NOT EXISTS Bd_Nomina;
USE Bd_Nomina;

-- ===========================
-- TABLA: Tbl_Departamentos
-- ===========================
CREATE TABLE Tbl_Departamentos (
  Cmp_iId_Departamento INT AUTO_INCREMENT,
  Cmp_sNombre_Departamento VARCHAR(50) UNIQUE NOT NULL,
  Cmp_sDescripcion_Departamento VARCHAR(255),
  CONSTRAINT Pk_Id_Departamentos PRIMARY KEY (Cmp_iId_Departamento)
);

-- ===========================
-- TABLA: Tbl_Puestos
-- ===========================
CREATE TABLE Tbl_Puestos (
  Cmp_iId_Puesto INT AUTO_INCREMENT,
  Cmp_sNombre_Puesto VARCHAR(50) NOT NULL,
  Cmp_sDescripcion_Puesto VARCHAR(255),
  Cmp_iId_Departamento INT NOT NULL,
  CONSTRAINT Pk_Id_Puestos PRIMARY KEY (Cmp_iId_Puesto),
  CONSTRAINT Fk_Puestos_Departamentos FOREIGN KEY (Cmp_iId_Departamento)
    REFERENCES Tbl_Departamentos(Cmp_iId_Departamento)
);
CREATE INDEX Ix_Puestos_IdDepartamento ON Tbl_Puestos(Cmp_iId_Departamento);

-- ===========================
-- TABLA: Tbl_Empleados
-- ===========================
CREATE TABLE Tbl_Empleados (
  Cmp_iId_Empleado INT AUTO_INCREMENT,
  Cmp_sNombre_Empleado VARCHAR(50) NOT NULL,
  Cmp_sApellido_Empleado VARCHAR(50) NOT NULL,
  Cmp_sDpi_Empleado VARCHAR(20) UNIQUE,
  Cmp_iNit_Empleado INT,
  Cmp_sCorreo_Empleado VARCHAR(50),
  Cmp_sTelefono_Empleado VARCHAR(15),
  Cmp_bGenero_Empleado BIT(1),
  Cmp_dFechaNacimiento_Empleado DATE,
  Cmp_dFechaIngreso_Empleado DATETIME,
  Cmp_deSalario_Empleado DECIMAL(10,2),
  Cmp_iId_Puesto INT NOT NULL,
  Cmp_bEstado_Empleado BIT(1),
  CONSTRAINT Pk_Id_Empleados PRIMARY KEY (Cmp_iId_Empleado),
  CONSTRAINT Fk_Empleados_Puestos FOREIGN KEY (Cmp_iId_Puesto)
    REFERENCES Tbl_Puestos(Cmp_iId_Puesto)
);
CREATE INDEX Ix_Empleados_IdPuesto ON Tbl_Empleados(Cmp_iId_Puesto);

-- ===========================
-- TABLA: Tbl_Anticipos
-- ===========================
CREATE TABLE Tbl_Anticipos (
  Cmp_iId_Anticipo INT AUTO_INCREMENT,
  Cmp_iId_Empleado INT NOT NULL,
  Cmp_deMonto_Anticipo DECIMAL(10,2),
  Cmp_dFecha_Anticipo DATETIME,
  Cmp_sMotivo_Anticipo VARCHAR(255),
  Cmp_deSaldoPendiente_Anticipo DECIMAL(10,2),
  CONSTRAINT Pk_Id_Anticipos PRIMARY KEY (Cmp_iId_Anticipo),
  CONSTRAINT Fk_Anticipos_Empleados FOREIGN KEY (Cmp_iId_Empleado)
    REFERENCES Tbl_Empleados(Cmp_iId_Empleado)
);
CREATE INDEX Ix_Anticipos_IdEmpleado ON Tbl_Anticipos(Cmp_iId_Empleado);

-- ===========================
-- TABLA: Tbl_Asistencias
-- ===========================
CREATE TABLE Tbl_Asistencias (
  Cmp_iId_Asistencia INT AUTO_INCREMENT,
  Cmp_iId_Empleado INT NOT NULL,
  Cmp_dFecha_Asistencia DATETIME,
  Cmp_tHoraEntrada_Asistencia TIME,
  Cmp_tHoraSalida_Asistencia TIME,
  CONSTRAINT Pk_Id_Asistencias PRIMARY KEY (Cmp_iId_Asistencia),
  CONSTRAINT Fk_Asistencias_Empleados FOREIGN KEY (Cmp_iId_Empleado)
    REFERENCES Tbl_Empleados(Cmp_iId_Empleado)
);
CREATE INDEX Ix_Asistencias_IdEmpleado ON Tbl_Asistencias(Cmp_iId_Empleado);

-- ===========================
-- TABLA: Tbl_HorasExtra
-- ===========================
CREATE TABLE Tbl_HorasExtra (
  Cmp_iId_HoraExtra INT AUTO_INCREMENT,
  Cmp_iId_Empleado INT NOT NULL,
  Cmp_dFecha_HoraExtra DATETIME,
  Cmp_iCantidad_HoraExtra INT,
  Cmp_sMotivo_HoraExtra VARCHAR(255),
  Cmp_bAprobado_HoraExtra BIT(1),
  CONSTRAINT Pk_Id_HorasExtra PRIMARY KEY (Cmp_iId_HoraExtra),
  CONSTRAINT Fk_HorasExtra_Empleados FOREIGN KEY (Cmp_iId_Empleado)
    REFERENCES Tbl_Empleados(Cmp_iId_Empleado)
);
CREATE INDEX Ix_HorasExtra_IdEmpleado ON Tbl_HorasExtra(Cmp_iId_Empleado);

-- ===========================
-- TABLA: Tbl_AusenciasPermisos
-- ===========================
CREATE TABLE Tbl_AusenciasPermisos (
  Cmp_iId_AusenciaPermiso INT AUTO_INCREMENT,
  Cmp_iId_Empleado INT NOT NULL,
  Cmp_dFecha_AusenciaPermiso DATETIME,
  Cmp_sTipo_AusenciaPermiso VARCHAR(50),
  Cmp_bJustificada_AusenciaPermiso BIT(1),
  Cmp_sMotivo_AusenciaPermiso VARCHAR(255),
  Cmp_sObservacion_AusenciaPermiso VARCHAR(255),
  CONSTRAINT Pk_Id_AusenciasPermisos PRIMARY KEY (Cmp_iId_AusenciaPermiso),
  CONSTRAINT Fk_AusenciasPermisos_Empleados FOREIGN KEY (Cmp_iId_Empleado)
    REFERENCES Tbl_Empleados(Cmp_iId_Empleado)
);
CREATE INDEX Ix_AusenciasPermisos_IdEmpleado ON Tbl_AusenciasPermisos(Cmp_iId_Empleado);

-- ===========================
-- TABLA: Tbl_Vacaciones
-- ===========================
CREATE TABLE Tbl_Vacaciones (
  Cmp_iId_Vacacion INT AUTO_INCREMENT,
  Cmp_iId_Empleado INT NOT NULL,
  Cmp_dFechaInicio_Vacacion DATETIME,
  Cmp_dFechaFin_Vacacion DATETIME,
  Cmp_iDias_Vacacion INT,
  Cmp_bAprobada_Vacacion BIT(1),
  CONSTRAINT Pk_Id_Vacaciones PRIMARY KEY (Cmp_iId_Vacacion),
  CONSTRAINT Fk_Vacaciones_Empleados FOREIGN KEY (Cmp_iId_Empleado)
    REFERENCES Tbl_Empleados(Cmp_iId_Empleado)
);
CREATE INDEX Ix_Vacaciones_IdEmpleado ON Tbl_Vacaciones(Cmp_iId_Empleado);

-- ===========================
-- TABLA: Tbl_Prestamos
-- ===========================
CREATE TABLE Tbl_Prestamos (
  Cmp_iId_Prestamo INT AUTO_INCREMENT,
  Cmp_iId_Empleado INT NOT NULL,
  Cmp_deMonto_Prestamo DECIMAL(10,2),
  Cmp_dFecha_Prestamo DATETIME,
  Cmp_deSaldoPendiente_Prestamo DECIMAL(10,2),
  CONSTRAINT Pk_Id_Prestamos PRIMARY KEY (Cmp_iId_Prestamo),
  CONSTRAINT Fk_Prestamos_Empleados FOREIGN KEY (Cmp_iId_Empleado)
    REFERENCES Tbl_Empleados(Cmp_iId_Empleado)
);
CREATE INDEX Ix_Prestamos_IdEmpleado ON Tbl_Prestamos(Cmp_iId_Empleado);

-- ===========================
-- TABLA: Tbl_Nomina
-- ===========================
CREATE TABLE Tbl_Nomina (
  Cmp_iId_Nomina INT AUTO_INCREMENT,
  Cmp_dPeriodoInicio_Nomina DATETIME,
  Cmp_dPeriodoFin_Nomina DATETIME,
  Cmp_dFechaGeneracion_Nomina DATETIME,
  Cmp_sTipo_Nomina VARCHAR(50),
  Cmp_sEstado_Nomina VARCHAR(50),
  CONSTRAINT Pk_Id_Nomina PRIMARY KEY (Cmp_iId_Nomina)
);

-- ===========================
-- TABLA: Tbl_DetallesNomina
-- ===========================
CREATE TABLE Tbl_DetallesNomina (
  Cmp_iId_DetalleNomina INT AUTO_INCREMENT,
  Cmp_iId_Nomina INT NOT NULL,
  Cmp_iId_Empleado INT NOT NULL,
  Cmp_iAusencias_DetalleNomina INT,
  Cmp_iDiasLaborados_DetalleNomina INT,
  Cmp_dePercepciones_DetalleNomina DECIMAL(10,2),
  Cmp_deDeducciones_DetalleNomina DECIMAL(10,2),
  Cmp_deSueldoLiquido_DetalleNomina DECIMAL(10,2),
  CONSTRAINT Pk_Id_DetallesNomina PRIMARY KEY (Cmp_iId_DetalleNomina),
  CONSTRAINT Fk_DetallesNomina_Nomina FOREIGN KEY (Cmp_iId_Nomina)
    REFERENCES Tbl_Nomina(Cmp_iId_Nomina),
  CONSTRAINT Fk_DetallesNomina_Empleados FOREIGN KEY (Cmp_iId_Empleado)
    REFERENCES Tbl_Empleados(Cmp_iId_Empleado)
);
CREATE INDEX Ix_DetallesNomina_IdEmpleado ON Tbl_DetallesNomina(Cmp_iId_Empleado);

-- ===========================
-- TABLA: Tbl_ConceptosNomina
-- ===========================
CREATE TABLE Tbl_ConceptosNomina (
  Cmp_iId_ConceptoNomina INT AUTO_INCREMENT,
  Cmp_sNombre_ConceptoNomina VARCHAR(50) NOT NULL,
  Cmp_sDescripcion_ConceptoNomina VARCHAR(255),
  Cmp_sTipo_ConceptoNomina VARCHAR(50), -- PERCEPCION / DEDUCCION
  Cmp_sTipoCalculo_ConceptoNomina VARCHAR(50) DEFAULT 'MULT', -- MULTIPLICACION, FIJO, PORCENTAJE
  Cmp_deValor_ConceptoNomina DECIMAL(10,4),
  Cmp_bAplicaAutomatico_ConceptoNomina BIT(1) DEFAULT 0,
  CONSTRAINT Pk_Id_ConceptosNomina PRIMARY KEY (Cmp_iId_ConceptoNomina)
);


-- ==========================================================
-- DATOS INICIALES: CONCEPTOS DE NÓMINA AUTOMÁTICOS
-- ==========================================================

INSERT INTO Tbl_ConceptosNomina 
(Cmp_sNombre_ConceptoNomina, Cmp_sDescripcion_ConceptoNomina, 
 Cmp_sTipo_ConceptoNomina, Cmp_sTipoCalculo_ConceptoNomina, 
 Cmp_deValor_ConceptoNomina, Cmp_bAplicaAutomatico_ConceptoNomina)
VALUES

('Bono Trimestral', 'Bono Trimestral', 'PERCEPCION', 'FIJO', 550.00, 0),
('Horas Extra', 'Monto de horas extra', 'PERCEPCION', 'MULTIPLICACION', 0.00, 1),
('Ausencias', 'Monto de ausencias', 'DEDUCCION', 'MULTIPLICACION', 0.00, 1),
('Anticipos', 'Monto de anticipos', 'DEDUCCION', 'FIJO', 0.00, 1),
('Vacaciones', 'Monto de vacaciones', 'PERCEPCION', 'MULTIPLICACION', 0.00, 1),
('Comisiones', 'Monto de comisiones', 'PERCEPCION', 'FIJO', 0.00, 0),
('Sueldo Base', 'Pago base mensual del empleado', 'PERCEPCION', 'FIJO', 0.00, 1),
('IGSS', 'Aporte laboral al IGSS', 'DEDUCCION', 'MULTIPLICACION', 0.0483, 1),
('ISR', 'Retención de impuesto sobre la renta', 'DEDUCCION', 'MULTIPLICACION', 0.05, 1);


-- ===========================
-- TABLA: Tbl_MovimientosNomina
-- ===========================
CREATE TABLE Tbl_MovimientosNomina (
  Cmp_iId_MovimientoNomina INT AUTO_INCREMENT,
  Cmp_iId_Nomina INT NOT NULL,
  Cmp_iId_ConceptoNomina INT NOT NULL,
  Cmp_deMonto_MovimientoNomina DECIMAL(10,2),
  CONSTRAINT Pk_Id_MovimientosNomina PRIMARY KEY (Cmp_iId_MovimientoNomina),
  CONSTRAINT Fk_MovimientosNomina_Nomina FOREIGN KEY (Cmp_iId_Nomina)
    REFERENCES Tbl_Nomina(Cmp_iId_Nomina),
  CONSTRAINT Fk_MovimientosNomina_Conceptos FOREIGN KEY (Cmp_iId_ConceptoNomina)
    REFERENCES Tbl_ConceptosNomina(Cmp_iId_ConceptoNomina)
);
CREATE INDEX Ix_MovimientosNomina_IdNomina ON Tbl_MovimientosNomina(Cmp_iId_Nomina);

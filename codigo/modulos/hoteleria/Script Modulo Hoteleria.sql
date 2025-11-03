CREATE DATABASE IF NOT EXISTS bd_Modulo_Hoteleria;
USE bd_modulo_hoteleria;

CREATE TABLE tbl_reportes (
  Pk_Id_Reporte INT NOT NULL AUTO_INCREMENT,
  Cmp_Titulo_Reporte VARCHAR(50) DEFAULT NULL,
  Cmp_Ruta_Reporte VARCHAR(500) DEFAULT NULL,
  Cmp_Fecha_Reporte DATE DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Reporte)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_aplicacion (
  Pk_Id_Aplicacion INT NOT NULL,
  Fk_Id_Reporte_Aplicacion INT DEFAULT NULL,
  Cmp_Nombre_Aplicacion VARCHAR(50) DEFAULT NULL,
  Cmp_Descripcion_Aplicacion VARCHAR(50) DEFAULT NULL,
  Cmp_Estado_Aplicacion BIT(1) NOT NULL,
  PRIMARY KEY (Pk_Id_Aplicacion),
  KEY Fk_Aplicacion_Reporte (Fk_Id_Reporte_Aplicacion),
  CONSTRAINT Fk_Aplicacion_Reporte FOREIGN KEY (Fk_Id_Reporte_Aplicacion) REFERENCES tbl_reportes (Pk_Id_Reporte)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_modulo (
  Pk_Id_Modulo INT NOT NULL,
  Cmp_Nombre_Modulo VARCHAR(50) DEFAULT NULL,
  Cmp_Descripcion_Modulo VARCHAR(50) DEFAULT NULL,
  Cmp_Estado_Modulo BIT(1) NOT NULL,
  PRIMARY KEY (Pk_Id_Modulo)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_asignacion_modulo_aplicacion (
  Fk_Id_Modulo INT NOT NULL,
  Fk_Id_Aplicacion INT NOT NULL,
  PRIMARY KEY (Fk_Id_Modulo, Fk_Id_Aplicacion),
  KEY Fk_AsigAplicacion (Fk_Id_Aplicacion),
  CONSTRAINT Fk_AsigAplicacion FOREIGN KEY (Fk_Id_Aplicacion) REFERENCES tbl_aplicacion (Pk_Id_Aplicacion),
  CONSTRAINT Fk_AsigModulo FOREIGN KEY (Fk_Id_Modulo) REFERENCES tbl_modulo (Pk_Id_Modulo)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_perfil (
  Pk_Id_Perfil INT NOT NULL AUTO_INCREMENT,
  Cmp_Puesto_Perfil VARCHAR(50) DEFAULT NULL,
  Cmp_Descripcion_Perfil VARCHAR(50) DEFAULT NULL,
  Cmp_Estado_Perfil BIT(1) NOT NULL,
  Cmp_Tipo_Perfil INT DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Perfil)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_permiso_perfil_aplicacion (
  Fk_Id_Perfil INT NOT NULL,
  Fk_Id_Modulo INT NOT NULL,
  Fk_Id_Aplicacion INT NOT NULL,
  Cmp_Ingresar_Permisos_Aplicacion_Perfil BIT(1) DEFAULT NULL,
  Cmp_Consultar_Permisos_Aplicacion_Perfil BIT(1) DEFAULT NULL,
  Cmp_Modificar_Permisos_Aplicacion_Perfil BIT(1) DEFAULT NULL,
  Cmp_Eliminar_Permisos_Aplicacion_Perfil BIT(1) DEFAULT NULL,
  Cmp_Imprimir_Permisos_Aplicacion_Perfil BIT(1) DEFAULT NULL,
  PRIMARY KEY (Fk_Id_Perfil, Fk_Id_Modulo, Fk_Id_Aplicacion),
  KEY Fk_PermisoPerfil_ModuloAplicacion (Fk_Id_Modulo, Fk_Id_Aplicacion),
  CONSTRAINT Fk_PermisoPerfil FOREIGN KEY (Fk_Id_Perfil) REFERENCES tbl_perfil (Pk_Id_Perfil) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT Fk_PermisoPerfil_ModuloAplicacion FOREIGN KEY (Fk_Id_Modulo, Fk_Id_Aplicacion) REFERENCES tbl_asignacion_modulo_aplicacion (Fk_Id_Modulo, Fk_Id_Aplicacion) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_empleado (
  Pk_Id_Empleado INT NOT NULL AUTO_INCREMENT,
  Cmp_Nombres_Empleado VARCHAR(50) DEFAULT NULL,
  Cmp_Apellidos_Empleado VARCHAR(50) DEFAULT NULL,
  Cmp_Dpi_Empleado BIGINT DEFAULT NULL,
  Cmp_Nit_Empleado BIGINT DEFAULT NULL,
  Cmp_Correo_Empleado VARCHAR(50) DEFAULT NULL,
  Cmp_Telefono_Empleado VARCHAR(15) DEFAULT NULL,
  Cmp_Genero_Empleado BIT(1) DEFAULT NULL,
  Cmp_Fecha_Nacimiento_Empleado DATE DEFAULT NULL,
  Cmp_Fecha_Contratacion__Empleado DATE DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Empleado)
) ENGINE=InnoDB AUTO_INCREMENT=5001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_usuario (
  Pk_Id_Usuario INT NOT NULL AUTO_INCREMENT,
  Fk_Id_Empleado INT DEFAULT NULL,
  Cmp_Nombre_Usuario VARCHAR(50) DEFAULT NULL,
  Cmp_Contrasena_Usuario VARCHAR(65) DEFAULT NULL,
  Cmp_Intentos_Fallidos_Usuario INT DEFAULT NULL,
  Cmp_Estado_Usuario BIT(1) DEFAULT NULL,
  Cmp_FechaCreacion_Usuario DATETIME DEFAULT NULL,
  Cmp_Ultimo_Cambio_Contrasenea DATETIME DEFAULT NULL,
  Cmp_Pidio_Cambio_Contrasenea BIT(1) DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Usuario),
  KEY Fk_Usuario_Empleado (Fk_Id_Empleado),
  CONSTRAINT Fk_Usuario_Empleado FOREIGN KEY (Fk_Id_Empleado) REFERENCES tbl_empleado (Pk_Id_Empleado) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_usuario_perfil (
  Fk_Id_Usuario INT NOT NULL,
  Fk_Id_Perfil INT NOT NULL,
  PRIMARY KEY (Fk_Id_Usuario, Fk_Id_Perfil),
  KEY Fk_UsuarioPerfil_Perfil (Fk_Id_Perfil),
  CONSTRAINT Fk_UsuarioPerfil_Perfil FOREIGN KEY (Fk_Id_Perfil) REFERENCES tbl_perfil (Pk_Id_Perfil),
  CONSTRAINT Fk_UsuarioPerfil_Usuario FOREIGN KEY (Fk_Id_Usuario) REFERENCES tbl_usuario (Pk_Id_Usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_cliente (
  Pk_Id_Cliente INT NOT NULL,
  Cmp_Nombres_Cliente VARCHAR(50) DEFAULT NULL,
  Cmp_Apellidos_Cliente VARCHAR(50) DEFAULT NULL,
  Cmp_Dni_Cliente BIGINT DEFAULT NULL,
  Cmp_Fecha_Registro_Cliente DATETIME DEFAULT NULL,
  Cmp_Estado_Cliente BIT(1) DEFAULT NULL,
  Cmp_Nacionalidad_Cliente VARCHAR(50) DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Cliente)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_correo_cliente (
  Pk_Id_Correo INT NOT NULL,
  Fk_Id_Cliente INT DEFAULT NULL,
  Cmp_Correo_Cliente VARCHAR(50) DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Correo),
  KEY Fk_Correo_Cliente (Fk_Id_Cliente),
  CONSTRAINT Fk_Correo_Cliente FOREIGN KEY (Fk_Id_Cliente) REFERENCES tbl_cliente (Pk_Id_Cliente)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_numero_cliente (
  Pk_Id_Numero INT NOT NULL,
  Fk_Id_Cliente INT DEFAULT NULL,
  Cmp_Telefono_Cliente VARCHAR(15) DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Numero),
  KEY Fk_Numero_Cliente (Fk_Id_Cliente),
  CONSTRAINT Fk_Numero_Cliente FOREIGN KEY (Fk_Id_Cliente) REFERENCES tbl_cliente (Pk_Id_Cliente)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_nit_cliente (
  Pk_Id_Nit INT NOT NULL,
  Fk_Id_Cliente INT DEFAULT NULL,
  Cmp_Nit_Cliente VARCHAR(15) DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Nit),
  KEY Fk_Nit_Cliente (Fk_Id_Cliente),
  CONSTRAINT Fk_Nit_Cliente FOREIGN KEY (Fk_Id_Cliente) REFERENCES tbl_cliente (Pk_Id_Cliente)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_bitacora (
  Pk_Id_Bitacora INT NOT NULL AUTO_INCREMENT,
  Fk_Id_Usuario INT NULL,
  Fk_Id_Aplicacion INT NULL,
  Cmp_Fecha DATETIME NULL,
  Cmp_Accion VARCHAR(255) NULL,
  Cmp_Ip VARCHAR(50) NULL,
  Cmp_Nombre_Pc VARCHAR(50) NULL,
  Cmp_Login_Estado BIT(1) NULL,
  PRIMARY KEY (Pk_Id_Bitacora),
  CONSTRAINT Fk_Bitacora_Usuario FOREIGN KEY (Fk_Id_Usuario) REFERENCES tbl_usuario (Pk_Id_Usuario),
  CONSTRAINT Fk_Bitacora_Aplicacion FOREIGN KEY (Fk_Id_Aplicacion) REFERENCES tbl_aplicacion (Pk_Id_Aplicacion) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_bloqueo_usuario (
  Pk_Id_Bloqueo INT NOT NULL AUTO_INCREMENT,
  Fk_Id_Usuario INT DEFAULT NULL,
  Fk_Id_Bitacora INT DEFAULT NULL,
  Cmp_Fecha_Inicio_Bloqueo_Usuario DATETIME DEFAULT NULL,
  Cmp_Fecha_Fin_Bloqueo_Usuario DATETIME DEFAULT NULL,
  Cmp_Motivo__Bloqueo_Usuario VARCHAR(50) DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Bloqueo),
  KEY Fk_Bloqueo_Usuario (Fk_Id_Usuario),
  KEY Fk_Bloqueo_Bitacora (Fk_Id_Bitacora),
  CONSTRAINT Fk_Bloqueo_Bitacora FOREIGN KEY (Fk_Id_Bitacora) REFERENCES tbl_bitacora (Pk_Id_Bitacora),
  CONSTRAINT Fk_Bloqueo_Usuario FOREIGN KEY (Fk_Id_Usuario) REFERENCES tbl_usuario (Pk_Id_Usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_permiso_usuario_aplicacion (
  Fk_Id_Usuario INT NOT NULL,
  Fk_Id_Modulo INT NOT NULL,
  Fk_Id_Aplicacion INT NOT NULL,
  Cmp_Ingresar_Permiso_Aplicacion_Usuario BIT(1) DEFAULT NULL,
  Cmp_Consultar_Permiso_Aplicacion_Usuario BIT(1) DEFAULT NULL,
  Cmp_Modificar_Permiso_Aplicacion_Usuario BIT(1) DEFAULT NULL,
  Cmp_Eliminar_Permiso_Aplicacion_Usuario BIT(1) DEFAULT NULL,
  Cmp_Imprimir_Permiso_Aplicacion_Usuario BIT(1) DEFAULT NULL,
  PRIMARY KEY (Fk_Id_Usuario, Fk_Id_Modulo, Fk_Id_Aplicacion),
  KEY Fk_Permiso_Modulo_Aplicacion (Fk_Id_Modulo, Fk_Id_Aplicacion),
  CONSTRAINT Fk_Permiso_Modulo_Aplicacion FOREIGN KEY (Fk_Id_Modulo, Fk_Id_Aplicacion) REFERENCES tbl_asignacion_modulo_aplicacion (Fk_Id_Modulo, Fk_Id_Aplicacion) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT Fk_Permiso_Usuario FOREIGN KEY (Fk_Id_Usuario) REFERENCES tbl_usuario (Pk_Id_Usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE tbl_token_restaurarcontrasena (
  Pk_Id_Token INT NOT NULL AUTO_INCREMENT,
  Fk_Id_Usuario INT DEFAULT NULL,
  Cmp_Token VARCHAR(50) DEFAULT NULL,
  Cmp_Fecha_Creacion_Restaurar_Contrasenea DATETIME DEFAULT NULL,
  Cmp_Expiracion_Restaurar_Contrasenea DATETIME DEFAULT NULL,
  Cmp_Utilizado_Restaurar_Contrasenea BIT(1) DEFAULT NULL,
  Cmp_Fecha_Uso_Restaurar_Contrasenea DATETIME DEFAULT NULL,
  PRIMARY KEY (Pk_Id_Token),
  KEY Fk_Token_Usuario (Fk_Id_Usuario),
  CONSTRAINT Fk_Token_Usuario FOREIGN KEY (Fk_Id_Usuario) REFERENCES tbl_usuario (Pk_Id_Usuario)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- TABLAS MAESTRAS BÁSICAS
CREATE TABLE Tbl_Tipo_Menu (
    Pk_Id_Tipo_Menu INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Tipo_Menu VARCHAR(50) NOT NULL
);

CREATE TABLE Tbl_Menu (
    Pk_Id_Menu INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Nombre_Platillo VARCHAR(50) NOT NULL,
    Cmp_Descripcion_Platillo VARCHAR(250),
    Cmp_Precio DECIMAL(10,2) NOT NULL,
    Fk_Id_Tipo_Menu INT,
    FOREIGN KEY (Fk_Id_Tipo_Menu) REFERENCES Tbl_Tipo_Menu(Pk_Id_Tipo_Menu)
);

CREATE TABLE Tbl_Materia_Prima (
    Pk_Id_Materia_Prima INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Materia_Prima VARCHAR(100) NOT NULL
);

CREATE TABLE Tbl_Receta (
    Pk_Id_Receta INT PRIMARY KEY AUTO_INCREMENT,
    Fk_Id_Menu INT,
    Fk_Id_Materia_Prima INT,
    Cmp_Cantidad DECIMAL(10,2) NOT NULL,
    Cmp_Unidad_Medida VARCHAR(50),
    FOREIGN KEY (Fk_Id_Menu) REFERENCES Tbl_Menu(Pk_Id_Menu),
    FOREIGN KEY (Fk_Id_Materia_Prima) REFERENCES Tbl_Materia_Prima(Pk_Id_Materia_Prima)
);

CREATE TABLE Tbl_Salones (
    Pk_Id_Salon INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Nombre_Salon VARCHAR(50) NOT NULL,
    Cmp_Ubicacion VARCHAR(50),
    Cmp_Capacidad INT,
    Cmp_Disponibilidad TINYINT(1) NOT NULL CHECK (Cmp_Disponibilidad IN (0, 1))
);

CREATE TABLE Tbl_Tipo_Habitacion (
    PK_ID_Tipo_Habitaciones INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Tipo_Habitacion VARCHAR(50) NOT NULL,
    Cmp_Descripcion_Tipo_Habitacion VARCHAR(200)
);

CREATE TABLE Tbl_Habitaciones (
    PK_ID_Habitaciones INT PRIMARY KEY,
    FK_ID_Tipo_Habitaciones INT,
    Cmp_Piso_Habitacion INT,
    Cmp_Descripcion_Habitacion VARCHAR(100),
    Cmp_Tamaño_Habitacion_m2 VARCHAR(75),
    Cmp_Estado_Habitacion BOOLEAN,	
    Cmp_Tarifa_Noche DOUBLE,
    FOREIGN KEY (FK_ID_Tipo_Habitaciones) REFERENCES Tbl_Tipo_Habitacion(PK_ID_Tipo_Habitaciones)
);

CREATE TABLE Tbl_Estadia (
  Pk_Id_Estadia INT AUTO_INCREMENT PRIMARY KEY,
  Fk_Id_Habitaciones INT,
  Fk_Id_Huesped_Checkin INT,
  Cmp_Num_Huespedes INT,
  Cmp_Fecha_Check_In DATE,
  Cmp_Fecha_Check_Out DATE,
  Cmp_Tiene_Reservacion BOOL,
  Cmp_Monto_Total_Pago DECIMAL(10,2),
  FOREIGN KEY (Fk_Id_Habitaciones) REFERENCES Tbl_Habitaciones(PK_Id_Habitaciones)
);


CREATE TABLE Tbl_Servicio_Adicional (
    Pk_Id_Servicio INT PRIMARY KEY AUTO_INCREMENT,
    Pk_Id_Reserva INT,
    Cmp_Tipo_Servicio VARCHAR(75),
    Cmp_Descripcion VARCHAR(100),
    Cmp_Costo DECIMAL(10,2)
);

CREATE TABLE Tbl_Servicios_habitacion (
    PK_ID_Servicio_habitacion INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Nombre_Servicio VARCHAR(50) NOT NULL
);

CREATE TABLE Tbl_Asignacion_habitacion_Servicio (
    Fk_ID_Habitacion INT,
    Fk_Id_Servicio INT,
    PRIMARY KEY (Fk_ID_Habitacion, Fk_Id_Servicio),
    FOREIGN KEY (Fk_ID_Habitacion) REFERENCES Tbl_Habitaciones(PK_ID_Habitaciones),
    FOREIGN KEY (Fk_Id_Servicio) REFERENCES Tbl_Servicios_habitacion(PK_ID_Servicio_habitacion)
);

-- TABLAS DE HUÉSPEDES Y RESERVAS
CREATE TABLE Tbl_Huesped (
    Pk_Id_Huesped INT AUTO_INCREMENT PRIMARY KEY,
    Cmp_Nombre VARCHAR(50) NOT NULL,
    Cmp_Apellido VARCHAR(50) NOT NULL,
    Cmp_Email VARCHAR(100),
    Cmp_Telefono VARCHAR(15),
    Cmp_Pais VARCHAR(50),
    Cmp_Viaja_Por_Trabajo BOOL,
    Cmp_Nombre_Empresa VARCHAR(100),
    Cmp_Numero_Documento VARCHAR(25) UNIQUE,
    Cmp_Tipo_Documento ENUM('DPI', 'Pasaporte')
);

CREATE TABLE Tbl_Buffet (
    Pk_Id_Buffet INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Tipo_Buffet VARCHAR(50),
    Cmp_Descripcion VARCHAR(100) DEFAULT NULL,
    Cmp_Incluido_En_Reserva BOOLEAN
);

CREATE TABLE Tbl_Reserva (
    Pk_Id_Reserva INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Huesped INT NOT NULL,
    Fk_Id_Habitacion INT,
    Fk_Id_Buffet INT,  -- ← se agregó esta columna
    Cmp_Fecha_Reserva DATE,
    Cmp_Fecha_Entrada DATE,
    Cmp_Fecha_Salida DATE,
    Cmp_Num_Huespedes INT,
    Cmp_Peticiones_Especiales VARCHAR(255),
    Cmp_Estado_Reserva ENUM('Pendiente','Confirmada','Cancelada'),
    Cmp_Total_Reserva DECIMAL(10,2),
    FOREIGN KEY (Fk_Id_Huesped) REFERENCES Tbl_Huesped(Pk_Id_Huesped),
    FOREIGN KEY (Fk_Id_Buffet) REFERENCES Tbl_Buffet(Pk_Id_Buffet)
);


CREATE TABLE Tbl_Reservas_Salones (
    Pk_Id_Reserva_Salon INT PRIMARY KEY AUTO_INCREMENT,
    Fk_Id_Huesped INT,
    Fk_Id_Salon INT,
    Cmp_Fecha_Reserva DATE,
    Cmp_Hora_Inicio TIME,
    Cmp_Hora_Fin TIME,
    Cmp_Cantidad_Personas INT,
    Cmp_Monto_Total DECIMAL(10,2),
    FOREIGN KEY (Fk_Id_Huesped) REFERENCES Tbl_Huesped(Pk_Id_Huesped),
    FOREIGN KEY (Fk_Id_Salon) REFERENCES Tbl_Salones(Pk_Id_Salon)
);

CREATE TABLE Tbl_Pedidos_Menu (
    Pk_Id_Pedido_Menu INT PRIMARY KEY AUTO_INCREMENT,
    Fk_Id_Reserva_Salon INT,
    Fk_Id_Menu INT,
    Cmp_Cantidad_Platillos INT,
    FOREIGN KEY (Fk_Id_Reserva_Salon) REFERENCES Tbl_Reservas_Salones(Pk_Id_Reserva_Salon),
    FOREIGN KEY (Fk_Id_Menu) REFERENCES Tbl_Menu(Pk_Id_Menu)
);

-- TABLAS DE CHECK-IN / CHECK-OUT
CREATE TABLE Tbl_Check_in (
    Pk_Id_Check_in INT PRIMARY KEY AUTO_INCREMENT,
    Fk_Id_Huesped INT,
    Fk_Id_Reserva INT,
    Cmp_Fecha_Check_In DATE,
    Cmp_Estado VARCHAR(50),
    FOREIGN KEY (Fk_Id_Huesped) REFERENCES Tbl_Huesped(Pk_Id_Huesped),
    FOREIGN KEY (Fk_Id_Reserva) REFERENCES Tbl_Reserva(Pk_Id_Reserva)
);

CREATE TABLE Tbl_Check_Out (
    Pk_Id_Check_out INT PRIMARY KEY AUTO_INCREMENT,
    Fk_Id_Check_In INT,
    Cmp_Fecha_Check_Out DATE,
    FOREIGN KEY (Fk_Id_Check_In) REFERENCES Tbl_Check_in(Pk_Id_Check_in)
);

-- TABLAS DE PRODUCCIÓN
CREATE TABLE Tbl_Ordenes_Produccion (
    Pk_Id_Orden_Produccion INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Fecha_Solicitud DATE,
    Cmp_Fecha_Registro DATE
);

CREATE TABLE Tbl_Detalle_Ordenes_Menu (
    Pk_Id_Detalle_Orden INT PRIMARY KEY AUTO_INCREMENT,
    Fk_Id_Orden_Produccion INT,
    Fk_Id_Menu INT,
    Cmp_Cantidad_Platillos INT,
    FOREIGN KEY (Fk_Id_Orden_Produccion) REFERENCES Tbl_Ordenes_Produccion(Pk_Id_Orden_Produccion),
    FOREIGN KEY (Fk_Id_Menu) REFERENCES Tbl_Menu(Pk_Id_Menu)
);

CREATE TABLE Tbl_Mobiliario (
    Pk_Id_Mobiliario INT PRIMARY KEY AUTO_INCREMENT,
    Cmp_Mobiliario VARCHAR(150) NOT NULL
);

CREATE TABLE Tbl_Detalle_Ordenes_Mobiliario (
    Pk_Id_Detalle_Orden_Mobiliario INT PRIMARY KEY AUTO_INCREMENT,
    Fk_Id_Orden_Produccion INT,
    Fk_Id_Mobiliario INT,
    Cmp_Cantidad_Mobiliario INT,
    FOREIGN KEY (Fk_Id_Orden_Produccion) REFERENCES Tbl_Ordenes_Produccion(Pk_Id_Orden_Produccion),
    FOREIGN KEY (Fk_Id_Mobiliario) REFERENCES Tbl_Mobiliario(Pk_Id_Mobiliario)
);

-- TABLA DE MANTENIMIENTO
CREATE TABLE Tbl_Mantenimiento (
    Pk_Id_Mantenimiento INT PRIMARY KEY AUTO_INCREMENT,
    Pk_Id_Salon INT,
    Fk_Id_Habitacion INT,
    Fk_Id_Empleado INT,
    Cmp_Tipo_Mantenimiento VARCHAR(50),
    Cmp_Descripcion_Mantenimiento VARCHAR(100),
    Cmp_Estado VARCHAR(50),
    Cmp_Fecha_Inicio_Mantenimiento DATE,
    Cmp_Fecha_Fin_Mantenimiento DATE,
    FOREIGN KEY (Pk_Id_Salon) REFERENCES Tbl_Salones(Pk_Id_Salon),
    FOREIGN KEY (Fk_Id_Habitacion) REFERENCES Tbl_Habitaciones(Pk_Id_Habitaciones),
    FOREIGN KEY (Fk_Id_Empleado) REFERENCES tbl_empleado(Pk_Id_Empleado)
);

-- TABLAS DE FACTURACIÓN Y PAGOS
CREATE TABLE Tbl_Factura (
    Pk_Id_Factura INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Reserva INT NOT NULL,
    Cmp_Fecha_Emision DATE,
    Cmp_Total_Factura DECIMAL(10,2),
    FOREIGN KEY (Fk_Id_Reserva) REFERENCES Tbl_Reserva(Pk_Id_Reserva)
);

CREATE TABLE Tbl_Pago (
    Pk_Id_Pago INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Reserva INT NOT NULL,
    Cmp_Metodo_Pago ENUM('Tarjeta', 'Efectivo', 'Transferencia'),
    Cmp_Nombre_Titular VARCHAR(50),
    Cmp_Numero_Tarjeta VARCHAR(20),
    Cmp_Fecha_Vencimiento DATE,
    Cmp_CVC INT,
    Cmp_Codigo_Postal INT,
    Cmp_Fecha_Pago DATE,
    Cmp_Monto_Total DECIMAL(10,2),
    Cmp_Estado_Pago ENUM('Pagado', 'Pendiente', 'Cancelado'),
    FOREIGN KEY (Fk_Id_Reserva) REFERENCES Tbl_Reserva(Pk_Id_Reserva)
);

-- TABLAS DE CIERRES Y REPORTES

CREATE TABLE Tbl_Movimiento_Modulo (
    Pk_Id_Movimiento INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Modulo INT NOT NULL,
    Cmp_Tipo_Movimiento ENUM('Ingreso','Egreso') NOT NULL,
    Cmp_Descripcion VARCHAR(200),
    Cmp_Monto DECIMAL(12,2) NOT NULL,
    Cmp_Fecha_Movimiento DATETIME NOT NULL,
    Fk_Id_Referencia INT,
    Cmp_Tabla_Origen VARCHAR(100),
    FOREIGN KEY (Fk_Id_Modulo) REFERENCES Tbl_Modulo(Pk_Id_Modulo)
);

CREATE TABLE  Tbl_Cierre_Produccion (
    Pk_Id_Cierre INT AUTO_INCREMENT PRIMARY KEY,
    Cmp_Fecha_Inicio DATE,
    Cmp_Fecha_Fin DATE,
    Cmp_Tipo_Cierre ENUM('Diario','Semanal','Mensual'),
    Cmp_Descripcion_General VARCHAR(200),
    Cmp_Total_Ingresos DECIMAL(12,2),
    Cmp_Total_Egresos DECIMAL(12,2),
    Cmp_Resultado_Final DECIMAL(12,2),
    Cmp_Fecha_Registro DATETIME DEFAULT NOW()
);

CREATE TABLE Tbl_Detalle_Cierre (
    Pk_Id_Detalle INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Cierre INT NOT NULL,
    Fk_Id_Modulo INT NOT NULL,
    Cmp_Ingresos_Modulo DECIMAL(10,2),
    Cmp_Egresos_Modulo DECIMAL(10,2),
    FOREIGN KEY (Fk_Id_Cierre) REFERENCES Tbl_Cierre_Produccion(Pk_Id_Cierre),
    FOREIGN KEY (Fk_Id_Modulo) REFERENCES Tbl_Modulo(Pk_Id_Modulo)
);



-- TABLAS ADICIONALES (Room Service, Buffet, Folios)

CREATE TABLE Tbl_Room_Service (
    Pk_Id_Room INT PRIMARY KEY AUTO_INCREMENT,
    FK_Id_Huesped INT,
    Fk_Id_Habitacion INT,
    Cmp_Fecha_Orden DATETIME,
    Cmp_Estado VARCHAR(20),
    FOREIGN KEY (FK_Id_Huesped) REFERENCES Tbl_Huesped(Pk_Id_Huesped),
    FOREIGN KEY (Fk_Id_Habitacion) REFERENCES Tbl_Habitaciones(PK_ID_Habitaciones),
    CONSTRAINT CHK_Estado_Room_Service CHECK (Cmp_Estado IN ('Entregado', 'No entregado'))
);


CREATE TABLE Tbl_Room_Service_Detalle (
    Pk_Id_Detalle INT PRIMARY KEY AUTO_INCREMENT,
    FK_Id_Room INT,
    FK_Id_Menu INT,
    Cmp_Cantidad INT,
    Cmp_Precio_Unitario DECIMAL(10,2),
    Cmp_Subtotal DECIMAL(10,2),
    FOREIGN KEY (FK_Id_Room) REFERENCES Tbl_Room_Service(Pk_Id_Room),
    FOREIGN KEY (FK_Id_Menu) REFERENCES Tbl_Menu(Pk_Id_Menu)
);


CREATE TABLE Tbl_Puntos_Huesped (
    Pk_Id_Puntos_Huesped INT AUTO_INCREMENT PRIMARY KEY,
    Fk_Id_Huesped INT NOT NULL,
    Cmp_Puntos_Acumulados INT DEFAULT 0,
    Cmp_Puntos_Obtenidos INT DEFAULT 0,
    Cmp_Puntos_Canjeados INT DEFAULT 0,
    Cmp_Fecha_Ultima_Actualizacion DATE,
    FOREIGN KEY (Fk_Id_Huesped) REFERENCES Tbl_Huesped(Pk_Id_Huesped)
);



CREATE TABLE Tbl_Area (
  Pk_Id_Area INT AUTO_INCREMENT PRIMARY KEY,
  Cmp_Nombre_Area VARCHAR(50),
  Cmp_Descripcion VARCHAR(50),
  Cmp_Tipo_Movimiento VARCHAR(50),
  Cmp_Monto DECIMAL(10,2),
  Cmp_Fecha_Movimiento DATETIME
);

-- ==========================================================
--  CREACIÓN DE TABLA Tbl_Folio
-- ==========================================================

CREATE TABLE Tbl_Folio (
  Pk_Id_Folio INT AUTO_INCREMENT PRIMARY KEY,
  Fk_Id_Check_In INT,
  Fk_Id_Check_Out INT,
  Fk_Id_Habitacion INT,
  Cmp_Fecha_Creacion DATETIME DEFAULT NOW(),
  Cmp_Fecha_Cierre DATETIME NULL,
  Cmp_Total_Cargos DECIMAL(10,2) DEFAULT 0,
  Cmp_Total_Abonos DECIMAL(10,2) DEFAULT 0,
  Cmp_Saldo_Final DECIMAL(10,2) DEFAULT 0,
  Cmp_Estado VARCHAR(50) DEFAULT 'Abierto',

  FOREIGN KEY (Fk_Id_Check_In) REFERENCES Tbl_Check_In(Pk_Id_Check_In),
  FOREIGN KEY (Fk_Id_Check_Out) REFERENCES Tbl_Check_Out(Pk_Id_Check_Out),
  FOREIGN KEY (Fk_Id_Habitacion) REFERENCES Tbl_Habitaciones(Pk_Id_Habitaciones)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- DDL
CREATE DATABASE Minerva;
GO
USE master
GO
CREATE LOGIN usrminerva WITH PASSWORD = '123456',
  DEFAULT_DATABASE = Minerva,
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO
USE Minerva
GO
CREATE USER usrminerva FOR LOGIN usrminerva
GO
ALTER ROLE db_owner ADD MEMBER usrminerva
GO

DROP TABLE IF EXISTS VentaDetalle;
DROP TABLE IF EXISTS Venta;
DROP TABLE IF EXISTS CompraDetalle;
DROP TABLE IF EXISTS Compra;
DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Proveedor;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Producto;
DROP TABLE IF EXISTS UnidadMedida;

CREATE TABLE UnidadMedida (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  descripcion VARCHAR(20) NOT NULL
);
CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idUnidadMedida INT NOT NULL,
  codigo VARCHAR(20) NOT NULL,
  descripcion VARCHAR(200) NOT NULL,
  saldo DECIMAL NOT NULL,
  precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
  CONSTRAINT fk_Producto_UnidadMedida FOREIGN KEY (idUnidadMedida) REFERENCES UnidadMedida(id)
);
CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL UNIQUE,
  direccion VARCHAR(250) NULL,
  celular BIGINT NULL,
  representante VARCHAR(50) NOT NULL
);
CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL UNIQUE,
  nombres VARCHAR(50) NOT NULL,
  primerApellido VARCHAR(50) NULL,
  segundoApellido VARCHAR(50) NULL,
  fechaNacimiento DATE NOT NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL UNIQUE,
  clave VARCHAR(250) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
);
CREATE TABLE Compra (
  id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProveedor INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL,
  total DECIMAL NOT NULL CHECK (total > 0),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);
CREATE TABLE CompraDetalle (
  id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra BIGINT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL CHECK (precioUnitario > 0),
  total DECIMAL NOT NULL CHECK (total > 0),
  CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);
CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE Venta (
  id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCliente INT NOT NULL,
  idUsuario INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL,
  total DECIMAL NOT NULL CHECK (total > 0),
  CONSTRAINT fk_Venta_Cliente FOREIGN KEY (idCliente) REFERENCES Cliente(id),
  CONSTRAINT fk_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id)
);
CREATE TABLE VentaDetalle (
  id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idVenta BIGINT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL CHECK (precioUnitario > 0),
  total DECIMAL NOT NULL CHECK (total > 0),
  CONSTRAINT fk_VentaDetalle_Venta FOREIGN KEY (idVenta) REFERENCES Venta(id),
  CONSTRAINT fk_VentaDetalle_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);


ALTER TABLE UnidadMedida ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE UnidadMedida ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE UnidadMedida ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE VentaDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE VentaDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE VentaDetalle ADD estado INT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

GO
DROP PROC IF EXISTS paProductoListar;
GO
CREATE PROC paProductoListar @parametro VARCHAR(50)
AS
  SELECT p.id, p.idUnidadMedida, p.codigo, p.descripcion, um.descripcion AS unidadMedida, 
         p.saldo, p.precioVenta, p.usuarioRegistro, p.fechaRegistro, p.estado
  FROM Producto p
  INNER JOIN UnidadMedida um ON um.id = p.idUnidadMedida
  WHERE p.estado=1 AND p.codigo+p.descripcion+um.descripcion LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY p.descripcion;
GO
EXEC paProductoListar 'papel carta';


-- DML
INSERT INTO UnidadMedida (descripcion)
VALUES ('Caja'), ('Docena'), ('Metro'), ('Paquete'), ('Pliego'), ('Unidad');

INSERT INTO Producto (idUnidadMedida, codigo, descripcion, saldo, precioVenta)
VALUES (1, 'BL008', 'Bolígrafo Pilot Color Azul', 0, 35);

INSERT INTO Producto (idUnidadMedida, codigo, descripcion, saldo, precioVenta)
VALUES (4, 'PB015', 'Papel Bond Tamaño Carta 75 g/m²', 0, 20);

INSERT INTO Producto (idUnidadMedida, codigo, descripcion, saldo, precioVenta)
VALUES (4, 'PB016', 'Papel Bond Tamaño Oficio 75 g/m²', 0, 23);

INSERT INTO Empleado (cedulaIdentidad, nombres, primerApellido, segundoApellido, 
    fechaNacimiento, direccion, celular, cargo)
VALUES ('123456', 'Juan', 'Pérez', 'López', '2006-12-25', 'Calle Loa 50', 71717171, 'Administrador');

INSERT INTO Usuario (idEmpleado, usuario, clave)
VALUES (1, 'jperez', 'i0hcoO/nssY6WOs9pOp5Xw==');

SELECT * FROM UnidadMedida;
SELECT * FROM Producto WHERE descripcion LIKE '%papel%';
SELECT * FROM Usuario;

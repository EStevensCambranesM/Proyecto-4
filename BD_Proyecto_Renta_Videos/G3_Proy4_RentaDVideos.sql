CREATE DATABASE IF NOT EXISTS RentaDeVideos;
USE RentaDeVideos;

-- ===============================================

CREATE TABLE `tblRolesEmpresa` (
    `IdRolPK` INT NOT NULL,
    `iNombreRol` VARCHAR(50) NOT NULL UNIQUE,
    `dcSueldoBase` DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (`IdRolPK`)
);

INSERT INTO tblRolesEmpresa VALUES(1, 'Administrador', 5906.00),
								  (2, 'Empleado', 3456.00),
                                  (3, 'Practicante', 1000.00);
select * from tblRolesEmpresa;
-- ==============================================================

CREATE TABLE `tblBitacoraUsuario` (
    `IdBitacoraUsuarioPK` INT NOT NULL AUTO_INCREMENT,
    `sAccion` VARCHAR(255) NOT NULL, -- Qué tipo de acción hizo
    `sCambios` VARCHAR(255) NOT NULL, -- Qué se cambió
    `sDescripcion` VARCHAR(255) NOT NULL, -- Quién hizo, alteró la entidad y cuándo
    `dFechaHoraMod` DATETIME NOT NULL, -- Fecha y hora que el usuario modificó algo
    PRIMARY KEY (`IdBitacoraUsuarioPK`)
);

INSERT INTO tblBitacoraUsuario
  (sAccion, sCambios, sDescripcion, dFechaHoraMod)
VALUES
  ('INSERT', 'Nuevo usuario con ID 1',         'Usuario ID 1 (jcsandoval) creado el 2025-07-31 08:30:00', '2025-07-31 08:30:00'),
  ('UPDATE', 'Empleado con ID 2 actualizado',   'Empleado ID 2 (Stevens Cambranes) modificado el 2025-07-31 09:00:00', '2025-07-31 09:00:00'),
  ('DELETE', 'Empleado con ID 3 eliminado',     'Empleado ID 3 (Diego Fernando Saquil) eliminado el 2025-07-31 09:30:00', '2025-07-31 09:30:00'),
  ('INSERT', 'Nuevo LogIn con ID 1',            'Credenciales ID 1 (jcsandoval) creadas el 2025-07-31 10:00:00',      '2025-07-31 10:00:00'),
  ('UPDATE', 'Actualización de LogIn con ID 3', 'Credenciales ID 3 (dsaquil) modificadas el 2025-07-31 10:30:00',    '2025-07-31 10:30:00');

-- ==============================================================
-- trigger de Insert
DELIMITER $$
CREATE TRIGGER triUsuarioInsert
AFTER INSERT ON tblUsuario
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES (
    'INSERT',
    CONCAT('Nuevo usuario con ID ', NEW.IdUsuarioPK),
    CONCAT('Usuario ID ', NEW.IdUsuarioPK, ' fue creado el ', NOW()),
    NOW()
  );
END$$
DELIMITER ;

-- trigger de update
DELIMITER $$
CREATE TRIGGER triUsuarioUpdate
AFTER UPDATE ON tblUsuario
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES (
    'UPDATE',
    CONCAT('Usuario con ID ', NEW.IdUsuarioPK, ' fue actualizado'),
    CONCAT('Actualización hecha el ', NOW()),
    NOW()
  );
END$$
DELIMITER ;

-- trigger de delete
DELIMITER $$
CREATE TRIGGER triUsuarioDelete
AFTER DELETE ON tblUsuario
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES (
    'DELETE',
    CONCAT('Usuario con ID ', OLD.IdUsuarioPK, ' fue eliminado'),
    CONCAT('Eliminación realizada el ', NOW()),
    NOW()
  );
END$$
DELIMITER ;

-- ==============================================================

CREATE TABLE `tblInfoEmpleado` (
    `IdInfoEmpleadoPK` INT NOT NULL AUTO_INCREMENT,
    `sCUI` VARCHAR(20) NOT NULL UNIQUE,
    `sNombre` VARCHAR(100) NOT NULL,
    `sApellido` VARCHAR(100) NOT NULL,
    `sCorreo` VARCHAR(100) NOT NULL,
    `cSexo` CHAR(1) NOT NULL, -- F. Femenino M. Masculino
    `sTelefono` VARCHAR(10) NOT NULL,
    `iRolFK` INT NOT NULL, -- 1. admin, 2. Empleado, 3. Practicante 
    PRIMARY KEY (`IdInfoEmpleadoPK`),
    FOREIGN KEY (`iRolFK`) REFERENCES `tblRolesEmpresa`(`IdRolPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

INSERT INTO tblInfoEmpleado (sCUI, sNombre, sApellido, sCorreo, cSexo, sTelefono, iRolFK)
VALUES('1234567890101', 'Juan Carlos', 'Sandoval', 'jcSandoval@gmail.com', 'M', '12345678', 1),
	  ('9876543210101', 'Stevens', 'Cambranes', 'sCambranes@gmail.com', 'M', '87654321', 2),
	  ('1298374650101', 'Diego Fernando', 'Saquil Gramajo', 'dsaquil@gmail.com', 'M', '18273645', 3);

select * from tblInfoEmpleado;

-- TRIGGERS PARA tblInfoEmpleado
DELIMITER $$
CREATE TRIGGER triInsertInfoEmpleado
AFTER INSERT ON tblInfoEmpleado
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('INSERT', CONCAT('Nuevo empleado ID ', NEW.IdInfoEmpleadoPK),
          CONCAT('Empleado ingresado el ', NOW()), NOW());
END$$

CREATE TRIGGER triUpdateInfoEmpleado
AFTER UPDATE ON tblInfoEmpleado
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('UPDATE', CONCAT('Empleado actualizado ID ', NEW.IdInfoEmpleadoPK),
          CONCAT('Actualizado el ', NOW()), NOW());
END$$

CREATE TRIGGER triDeleteInfoEmpleado
AFTER DELETE ON tblInfoEmpleado
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('DELETE', CONCAT('Empleado eliminado ID ', OLD.IdInfoEmpleadoPK),
          CONCAT('Eliminado el ', NOW()), NOW());
END$$
DELIMITER ;
-- ==============================================================

CREATE TABLE `tblLogIn` (
    `IdNuevoUsuarioPK` INT NOT NULL AUTO_INCREMENT,
    `iEmpleadoFK` INT NOT NULL,
    `sUsuario` VARCHAR(100) NOT NULL,
    `sCorreo` VARCHAR(100) NOT NULL,
    `sContraseña` VARCHAR(64) NOT NULL UNIQUE,
    PRIMARY KEY (`IdNuevoUsuarioPK`),
    FOREIGN KEY (`iEmpleadoFK`) REFERENCES `tblInfoEmpleado`(`IdInfoEmpleadoPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);
-- Contraseñas encriptadas con SHA2
INSERT INTO tblLogIn (iEmpleadoFK, sUsuario, sCorreo, sContraseña)
VALUES 
(1, 'jcsandoval', 'jcSandoval@gmail.com', SHA2('admin123', 256)),
(2, 'scambranes', 'sCambranes@gmail.com', SHA2('empleado456', 256)),
(3, 'dsaquil', 'dsaquil@gmail.com', SHA2('practicante789', 256));
select * from tblLogIn;

-- TRIGGERS PARA tblLogIn
DELIMITER $$
CREATE TRIGGER triInsertLogIn
AFTER INSERT ON tblLogIn
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('INSERT', CONCAT('Nuevo LogIn ID ', NEW.IdNuevoUsuarioPK),
          CONCAT('Credenciales creadas el ', NOW()), NOW());
END$$

CREATE TRIGGER triUpdateLogIn
AFTER UPDATE ON tblLogIn
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('UPDATE', CONCAT('Actualización LogIn ID ', NEW.IdNuevoUsuarioPK),
          CONCAT('Modificado el ', NOW()), NOW());
END$$

CREATE TRIGGER triDeleteLogIn
AFTER DELETE ON tblLogIn
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('DELETE', CONCAT('Eliminado LogIn ID ', OLD.IdNuevoUsuarioPK),
          CONCAT('Eliminado el ', NOW()), NOW());
END$$
DELIMITER ;

-- ==============================================================
CREATE TABLE `tblDescripcion` (
    `IdDescripcionPK` INT NOT NULL AUTO_INCREMENT,
    `tDuracion` TIME,
    `dAñoLanzamiento` DATE,
    `sClasificacionEdad` VARCHAR(100),
    `sDirector@` VARCHAR(100),
    `iGenero` CHAR(5), -- ACCI, COMED, SUSP, ETC.
    `cIdiomas` CHAR(5), -- es, en, etc.
    PRIMARY KEY (`IdDescripcionPK`)
);

-- Datos para tblDescripcion
INSERT INTO tblDescripcion (tDuracion, dAñoLanzamiento, sClasificacionEdad, `sDirector@`, iGenero, cIdiomas) VALUES
  ('01:50:00', '2021-05-15', 'PG-13', 'Alfonso Cuarón', 'DRAM', 'es'),
  ('02:10:00', '2019-12-20', 'PG',    'Greta Gerwig',    'COMED','en'),
  ('02:05:00', '2022-08-12', 'R',     'David Fincher',   'SUSP', 'en'),
  ('01:45:00', '2020-11-05', 'PG-13', 'Patty Jenkins',   'ACCI', 'en'),
  ('02:20:00', '2023-02-25', 'PG',    'Taika Waititi',   'FANT', 'en');

-- ==============================================================

CREATE TABLE `tblTipoVideo` (
    `CodVideoPK` INT NOT NULL,
    `iDescripcionFK` INT NOT NULL,
    `cFormato` CHAR(5) NOT NULL, -- VHS, DVD, BLUERAY, 4K Ultra HD
    `sNombre` VARCHAR(100) NOT NULL,
    PRIMARY KEY (`CodVideoPK`),
    FOREIGN KEY (`iDescripcionFK`) REFERENCES `tblDescripcion`(`IdDescripcionPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

-- Datos para tblTipoVideo
INSERT INTO tblTipoVideo (CodVideoPK, iDescripcionFK, cFormato, sNombre) VALUES
  (101, 1, 'DVD',  'Roma'),
  (102, 2, 'BLU-R','Mujercitas'),
  (103, 3, '4KUHD','Perdida'),
  (104, 4, 'DVD',  'Wonder Woman 1984'),
  (105, 5, 'VHS',  'Thor: Love and Thunder');
  
-- ==============================================================

CREATE TABLE `tblCompras` (
    `IdComprasPK` INT NOT NULL AUTO_INCREMENT,
    `dFechaCompra` DATETIME NOT NULL,
    `cEstadoCompra` CHAR(3) NOT NULL, -- COM = Completada, CAN = Cancelada
    `dcTotal` DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (`IdComprasPK`)
);

-- Datos para tblCompras
INSERT INTO tblCompras (dFechaCompra, cEstadoCompra, dcTotal) VALUES
  ('2025-06-01 10:30:00', 'COM', 1200.00),
  ('2025-06-05 14:00:00', 'CAN',  800.00),
  ('2025-06-10 09:15:00', 'COM',  450.00),
  ('2025-07-01 11:45:00', 'COM',  975.00),
  ('2025-07-03 16:20:00', 'COM',  600.00);

-- ==============================================================
CREATE TABLE `tblProveedores` (
    `IdProveedoresPK` INT NOT NULL AUTO_INCREMENT,
    `sNombre` VARCHAR(255) NOT NULL,
    `sDireccion` VARCHAR(255),
    `sTelefono` VARCHAR(20) NOT NULL,
    `sCorreo` VARCHAR(255) NOT NULL,
    `sContactoPrincipal` VARCHAR(255) NOT NULL,
    `bActivo` BOOLEAN NOT NULL, -- Indica si el proveedor sigue activo
    PRIMARY KEY (`IdProveedoresPK`)
);

-- Datos para tblProveedores
INSERT INTO tblProveedores (sNombre, sDireccion, sTelefono, sCorreo, sContactoPrincipal, bActivo) VALUES
  ('CineGuate S.A.',         'Av. Reforma 7-50, Zona 9',           '2501-2345',   'ventas@cineguate.com',    'Roberto Molina', TRUE),
  ('Películas y Series SA',  'Calle 10 12-34, Zona 1',              '2233-4455',   'contacto@pelyserie.com',  'Lorena Díaz',   TRUE),
  ('Distribuidora Central',  'Km 5 Carretera a El Salvador',        '2402-7788',   'info@distcentral.com',    'Esteban López', TRUE),
  ('Videos Retro',           'C. Eva García 18, Zona 2',            '2288-1122',   'retro@videos.com',        'María Ruiz',    FALSE),
  ('Importaciones 4K',       'Av. Simón Bolívar 25-60, Zona 3',     '2544-9900',   '4k@importaciones.com',    'Luis Hernández',TRUE);

-- ==============================================================
CREATE TABLE `tblProducto` (
    `IdProductoPK` INT NOT NULL AUTO_INCREMENT,
    `iProveedoresFK` INT NOT NULL,
    `sNombreProducto` VARCHAR(255) NOT NULL,
    `sDescripcion` VARCHAR(255), -- Descripción opcional del producto
    `iStock` INT NOT NULL,
    `dcPrecioProducto` DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (`IdProductoPK`),
    FOREIGN KEY (`iProveedoresFK`) REFERENCES `tblProveedores`(`IdProveedoresPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

-- Datos para tblProducto
INSERT INTO tblProducto (iProveedoresFK, sNombreProducto, sDescripcion, iStock, dcPrecioProducto) VALUES
  (1, 'Paquete DVD Clásicos',   'Colección de películas clásicas DVD',           30,   450.00),
  (2, 'Blu-Ray Drama Premium',  'Selección de dramas en Blu-Ray',                20,   600.00),
  (3, 'Combo UHD Acción',       'Películas de acción en 4K Ultra HD',            15,  1200.00),
  (4, 'VHS Edición Retro',      'Películas antiguas en formato VHS',             10,   250.00),
  (5, 'Pack Familiar DVD',      'Películas familiares en DVD',                   40,   350.00);

-- ==============================================================
CREATE TABLE `tblDetalleCompras` (
    `IdDetallePK` INT NOT NULL AUTO_INCREMENT,
    `ComprasFK` INT NOT NULL,
    `ProductoFK` INT NOT NULL,
    `iCantidad` INT NOT NULL, -- Cantidad de unidades compradas del producto
    `dcSubtotal` DECIMAL(10, 2) NOT NULL, -- Subtotal = Cantidad × Precio
    PRIMARY KEY (`IdDetallePK`),
    FOREIGN KEY (`ComprasFK`) REFERENCES `tblCompras`(`IdComprasPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION,
    FOREIGN KEY (`ProductoFK`) REFERENCES `tblProducto`(`IdProductoPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

-- Datos para tblDetalleCompras
INSERT INTO tblDetalleCompras (IdDetallePK, ComprasFK, ProductoFK, iCantidad, dcSubtotal) VALUES
  (201, 1, 1, 2,  900.00),
  (202, 2, 2, 1,  600.00),
  (203, 3, 3, 3, 3600.00),
  (204, 4, 4, 2,  500.00),
  (205, 5, 5, 1,  350.00);

-- ==============================================================

CREATE TABLE `tblCierre` (
    `IdCierrePK` INT NOT NULL AUTO_INCREMENT,
    `dcGanancias` DECIMAL(10, 2) NOT NULL,
    `dcPerdidas` DECIMAL(10, 2) NOT NULL,
    `iCantidadVideosRentados` INT NOT NULL,
    `iCantidadVideosPerdidos` INT NOT NULL,
    `dFechaHoraCierre` DATETIME NOT NULL,
    PRIMARY KEY (`IdCierrePK`)
);

-- Datos para tblCierre
INSERT INTO tblCierre (dcGanancias, dcPerdidas, iCantidadVideosRentados, iCantidadVideosPerdidos, dFechaHoraCierre) VALUES
  (1500.00, 200.00, 25, 3, '2025-07-31 23:59:59'),
  (1800.00, 150.00, 30, 2, '2025-07-30 23:59:59'),
  (1300.00, 100.00, 20, 1, '2025-07-29 23:59:59'),
  (2000.00, 250.00, 35, 5, '2025-07-28 23:59:59'),
  (1700.00, 180.00, 28, 4, '2025-07-27 23:59:59');

-- ==============================================================
CREATE TABLE `tblMembresíaCliente` (
    `IdMembresiaPK` INT NOT NULL AUTO_INCREMENT,
    `sNombre` VARCHAR(100) NOT NULL,
    `sApellido` VARCHAR(100) NOT NULL,
    `sDireccionVivienda` VARCHAR(255) NOT NULL,
    `iCantidadRentas` INT NOT NULL,
    `cEstado` CHAR(1) NOT NULL, -- A. Activa, C. Cancelada, V. Vencida
    `dFechaDeCreacion` DATETIME NOT NULL,
    `dFechaDeVencimiento` DATETIME NOT NULL,
    PRIMARY KEY (`IdMembresiaPK`)
);

-- tblMembresíaCliente
INSERT INTO tblMembresíaCliente
  (sNombre, sApellido, sDireccionVivienda, iCantidadRentas, cEstado, dFechaDeCreacion, dFechaDeVencimiento)
VALUES
  ('Sofía',  'García',     '3a Calle 4-56, Zona 5',    3,  'A',     '2025-07-02 09:00:00', '2025-08-02 23:59:59'),
  ('Diego',  'Martínez',   'Av. Las Américas 45',      1,  'V',     '2025-06-10 14:20:00', '2025-07-10 23:59:59'),
  ('Elena',  'Fuentes',    'Km 7 Carretera al Pacífico',2, 'A',     '2025-07-08 11:30:00', '2025-08-08 23:59:59'),
  ('Miguel', 'Paredes',    'C. Principal 123, Mixco',   4, 'C',     '2025-06-20 16:45:00', '2025-07-20 23:59:59'),
  ('Lucía',  'Vargas',     'Zona 15, Col. La Bendición',5, 'A',     '2025-07-05 08:15:00', '2025-08-05 23:59:59');

-- ==============================================================

CREATE TABLE `tblClientes` (
    `IdClientesPK` INT NOT NULL AUTO_INCREMENT,
    `iMembresiaClienteFK` INT NOT NULL UNIQUE,
    PRIMARY KEY (`IdClientesPK`),
    FOREIGN KEY (`iMembresiaClienteFK`) REFERENCES `tblMembresíaCliente`(`IdMembresiaPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

-- tblClientes (un cliente por cada membresía)
INSERT INTO tblClientes (iMembresiaClienteFK)
VALUES (1),(2),(3),(4),(5);

-- ==============================================================

CREATE TABLE `tblFactura` (
    `IdFacturaPK` INT NOT NULL AUTO_INCREMENT,
    `iNumeroFactura` INT NOT NULL,
    `sNIT` VARCHAR(25) NOT NULL,
    `sDireccionLocal` VARCHAR(100) NOT NULL,
    `dFechaEmision` DATETIME NOT NULL,
    `dcPrecioProducto` DECIMAL(10, 2) NOT NULL,
    `dcTotalCompra` DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (`IdFacturaPK`)
);

INSERT INTO tblFactura
  (iNumeroFactura, sNIT, sDireccionLocal, dFechaEmision, dcPrecioProducto, dcTotalCompra)
VALUES
  (2001, '1020304-5', '4a Av. 10-20, Zona 2',     '2025-07-02 10:15:00',  30.00, 90.00),
  (2002, '5060708-9', 'C. Los Pinos 33, Zona 8',   '2025-06-11 13:00:00',  25.00, 25.00),
  (2003, '1122334-5', 'Av. Reforma 1-50, Zona 10', '2025-07-09 17:30:00',  40.00, 160.00),
  (2004, '6677889-0', 'Km 9 Ruta Nacional',        '2025-06-21 09:45:00',  35.00, 70.00),
  (2005, '9988776-5', 'Zona 3, Col. El Pilar',     '2025-07-06 15:20:00',  20.00, 40.00);


-- ==============================================================

CREATE TABLE `tblRenta` (
    `IdRentaPK` INT NOT NULL AUTO_INCREMENT,
    `iClienteFK` INT NOT NULL,
    `iFacturaFK` INT NOT NULL,
    `iMetodoPago` INT NOT NULL, -- 1. Efectivo, 2. Tarjeta con recargo, etc
    `iEstado` INT NOT NULL, -- 1. activa, 2. devuelta, 3. vencida
    `bMora` BOOLEAN NOT NULL, -- True si tiene mora, False si no tiene mora
    `bDescuento` BOOLEAN NOT NULL, -- True si tiene descuento, False si no tiene descuento
    PRIMARY KEY (`IdRentaPK`),
    FOREIGN KEY (`iClienteFK`) REFERENCES `tblClientes`(`IdClientesPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION,
    FOREIGN KEY (`iFacturaFK`) REFERENCES `tblFactura`(`IdFacturaPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

-- tblRenta
INSERT INTO tblRenta
  (iClienteFK, iFacturaFK, iMetodoPago, iEstado, bMora, bDescuento)
VALUES
  (1, 1, 1, 1, FALSE, TRUE),  -- efectivo, activa, con descuento
  (2, 2, 2, 2, TRUE,  FALSE), -- tarjeta, devuelta, con mora
  (3, 3, 1, 1, FALSE, FALSE), -- efectivo, activa, sin descuento
  (4, 4, 2, 3, TRUE,  TRUE),  -- tarjeta, vencida, mora+descuento
  (5, 5, 1, 2, FALSE, TRUE);  -- efectivo, devuelta, con descuento


-- ==============================================================


CREATE TABLE `tblInventario` (
    `IdInventarioPK` INT NOT NULL AUTO_INCREMENT,
    `iRentaFK` INT NOT NULL,
    `iCodVideoFK` INT NOT NULL UNIQUE,
    `iDetalleComprasFK` INT NOT NULL,
    `iCantidadDisponible` INT NOT NULL, -- Cuántas películas o series hay (STOCK)
    `cEstado` CHAR(1) NOT NULL, -- D = Disponible, R = Rentado, P = Perdido, etc
    `dFechaRenta` DATETIME NOT NULL,
    `dFechaDevolucion` DATETIME NOT NULL,
    `dcPrecioRenta` DECIMAL(10, 2) NOT NULL,
    `dcPrecioPerdida` DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (`IdInventarioPK`),
    FOREIGN KEY (`iRentaFK`) REFERENCES `tblRenta`(`IdRentaPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION,
    FOREIGN KEY (`iCodVideoFK`) REFERENCES `tblTipoVideo`(`CodVideoPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION,
    FOREIGN KEY (`iDetalleComprasFK`) REFERENCES `tblDetalleCompras`(`IdDetallePK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

-- tblInventario
INSERT INTO tblInventario
  (iRentaFK, iCodVideoFK, iDetalleComprasFK, iCantidadDisponible, cEstado, dFechaRenta,          dFechaDevolucion,       dcPrecioRenta, dcPrecioPerdida)
VALUES
  (1, 101, 201,  9, 'R', '2025-07-02 10:15:00', '2025-07-09 10:15:00', 2.50, 15.00),
  (2, 102, 202,  7, 'P', '2025-06-11 13:00:00', '2025-06-18 13:00:00', 3.00, 20.00),
  (3, 103, 203,  6, 'D', '2025-07-09 17:30:00', '2025-07-16 17:30:00', 1.75, 12.00),
  (4, 104, 204, 11, 'R', '2025-06-21 09:45:00', '2025-06-28 09:45:00', 2.00, 18.00),
  (5, 105, 205,  8, 'D', '2025-07-06 15:20:00', '2025-07-13 15:20:00', 2.25, 16.00);


-- ==============================================================

CREATE TABLE `tblUsuario` (
    `IdUsuarioPK` INT NOT NULL AUTO_INCREMENT,
    `iBitacoraUsuariosFK` INT NOT NULL,
    `iLogInFK` INT NOT NULL UNIQUE,
    `iCierreFK` INT NOT NULL,
    `iInventarioFK` INT NOT NULL,
    PRIMARY KEY (`IdUsuarioPK`),
    FOREIGN KEY (`iBitacoraUsuariosFK`) REFERENCES `tblBitacoraUsuario`(`IdBitacoraUsuarioPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION,
    FOREIGN KEY (`iLogInFK`) REFERENCES `tblLogIn`(`IdNuevoUsuarioPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION,
    FOREIGN KEY (`iCierreFK`) REFERENCES `tblCierre`(`IdCierrePK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION,
    FOREIGN KEY (`iInventarioFK`) REFERENCES `tblInventario`(`IdInventarioPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

-- tblUsuario
INSERT INTO tblUsuario
  (iBitacoraUsuariosFK, iLogInFK, iCierreFK, iInventarioFK)
VALUES
  (1, 1, 1, 1),
  (2, 2, 2, 2),
  (3, 3, 3, 3);
  

SELECT IdBitacoraUsuarioPK, sAccion
  FROM tblBitacoraUsuario
  ORDER BY IdBitacoraUsuarioPK;

select * from tblUsuario;
select * from tblLogIn;
select * from tblCierre;
select * from tblInventario;
select * from tblBitacoraUsuario;
select * from tblRenta;
-- ==============================================================
-- TRIGGERS PARA tblUsuario
DELIMITER $$

CREATE TRIGGER triInsertUsuario
AFTER INSERT ON tblUsuario
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('INSERT', CONCAT('Nuevo usuario ID ', NEW.IdUsuarioPK),
          CONCAT('Usuario creado el ', NOW()), NOW());
END$$

CREATE TRIGGER triUpdateUsuario
AFTER UPDATE ON tblUsuario
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('UPDATE', CONCAT('Actualizado usuario ID ', NEW.IdUsuarioPK),
          CONCAT('Modificado el ', NOW()), NOW());
END$$

CREATE TRIGGER triDeleteUsuario
AFTER DELETE ON tblUsuario
FOR EACH ROW
BEGIN
  INSERT INTO tblBitacoraUsuario (sAccion, sCambios, sDescripcion, dFechaHoraMod)
  VALUES ('DELETE', CONCAT('Eliminado usuario ID ', OLD.IdUsuarioPK),
          CONCAT('Eliminado el ', NOW()), NOW());
END$$
DELIMITER ;
select * from tblUsuario;

SELECT User, Host, plugin 
  FROM mysql.user
 WHERE User='ESCM';
 
 ALTER TABLE tblFactura
ADD UNIQUE (iNumeroFactura);

show create table tblFactura;
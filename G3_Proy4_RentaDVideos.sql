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

CREATE TABLE `tblCompras` (
    `IdComprasPK` INT NOT NULL AUTO_INCREMENT,
    `dFechaCompra` DATETIME NOT NULL,
    `cEstadoCompra` CHAR(3) NOT NULL, -- COM = Completada, CAN = Cancelada
    `dcTotal` DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (`IdComprasPK`)
);

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

CREATE TABLE `tblClientes` (
    `IdClientesPK` INT NOT NULL AUTO_INCREMENT,
    `iMembresiaClienteFK` INT NOT NULL UNIQUE,
    PRIMARY KEY (`IdClientesPK`),
    FOREIGN KEY (`iMembresiaClienteFK`) REFERENCES `tblMembresíaCliente`(`IdMembresiaPK`)
        ON UPDATE NO ACTION ON DELETE NO ACTION
);

CREATE TABLE `tblFactura` (
    `IdFacturaPK` INT NOT NULL AUTO_INCREMENT,
    `iNumeroFactura` INT NOT NULL UNIQUE,
    `sNIT` VARCHAR(25) NOT NULL,
    `sDireccionLocal` VARCHAR(100) NOT NULL,
    `dFechaEmision` DATETIME NOT NULL,
    `dcPrecioProducto` DECIMAL(10, 2) NOT NULL,
    `dcTotalCompra` DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (`IdFacturaPK`)
);

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

-- 2.1 Configura el plugin (si aún no es mysql_native_password):
ALTER USER 'ESCM'@'localhost'
  IDENTIFIED WITH mysql_native_password BY 'escm1823';
-- 2.2 Otorga privilegios a localhost (socket):
GRANT ALL PRIVILEGES ON RentaDeVideos.* TO 'ESCM'@'localhost';
-- 2.3 Crea y otorga a 127.0.0.1 (TCP IPv4):
CREATE USER IF NOT EXISTS 'ESCM'@'127.0.0.1'
  IDENTIFIED WITH mysql_native_password BY 'escm1823';
GRANT ALL PRIVILEGES ON RentaDeVideos.* TO 'ESCM'@'127.0.0.1';
-- 2.4 Crea y otorga a ::1 (TCP IPv6):
CREATE USER IF NOT EXISTS 'ESCM'@'::1'
  IDENTIFIED WITH mysql_native_password BY 'escm1823';
GRANT ALL PRIVILEGES ON RentaDeVideos.* TO 'ESCM'@'::1';
FLUSH PRIVILEGES;

SELECT User, Host, plugin 
  FROM mysql.user
 WHERE User='ESCM';
 
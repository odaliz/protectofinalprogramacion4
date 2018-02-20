USE UCSystem_SQLServer
GO

CREATE TABLE participantes
(matricula VARCHAR (7) PRIMARY KEY NOT NULL,
nombres VARCHAR	(30),
apellidos VARCHAR (30),
cedula VARCHAR (13) NOT NULL,
direccion VARCHAR (50))
GO

CREATE TABLE equipos
(idequipo INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
descripcionequipo VARCHAR (40))
GO


CREATE TABLE estados
(idestado INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
descripcionestado VARCHAR (20))
GO

CREATE TABLE inventario
(idequipo INT NOT NULL,
serieequipo VARCHAR (20) NOT NULL PRIMARY KEY,
idestado INT NOT NULL,
FOREIGN KEY (idequipo) REFERENCES equipos (idequipo),
FOREIGN KEY (idestado) REFERENCES estados (idestado))
GO

CREATE TABLE cargos
(idcargo INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
descripcioncargo VARCHAR (40))
GO

CREATE TABLE empleados
(codigoempleado INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
nombre VARCHAR (30),
apellido VARCHAR (30),
cedula VARCHAR (13),
direccion VARCHAR (50),
idcargo INT,
sueldo MONEY,
FOREIGN KEY (idcargo) REFERENCES cargos (idcargo))
GO

CREATE TABLE movimientosequipos
(matricula  VARCHAR (7),
serieequipo VARCHAR (30),
idestado INT,
fechaestado VARCHAR (10) NOT NULL,
FOREIGN KEY (matricula) REFERENCES participantes (matricula),
FOREIGN KEY (serieequipo) REFERENCES inventario (serieequipo),
FOREIGN KEY (idestado) REFERENCES estados (idestado))
GO

CREATE TABLE tiposusuarios
(idtipousuario INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
tipousuario VARCHAR (20))
GO

CREATE TABLE loginusuario
(codigoempleado INT,
usuario VARCHAR (20),
idtipousuario INT,
clave VARCHAR (15),
idestado INT,
FOREIGN KEY (codigoempleado) REFERENCES empleados (codigoempleado),
FOREIGN KEY (idtipousuario) REFERENCES tiposusuarios (idtipousuario),
FOREIGN KEY (idestado) REFERENCES estados (idestado))
GO
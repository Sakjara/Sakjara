/*CREATE DATABASE MASTER357V
GO

USE MASTER357V
GO

CREATE TABLE PERSONAS
(
 RUT NVARCHAR(15) NOT NULL PRIMARY KEY,
 NOMBRE NVARCHAR(255) NOT NULL,
 FECHA_NACIMIENTO DATETIME NOT NULL,
 SEXO NVARCHAR(10) NOT NULL,
 ESTADO NVARCHAR(255) NOT NULL,
 PROFESION NVARCHAR(255) NOT NULL,
 TELEFONO NVARCHAR(255) NOT NULL,
 DIRECCION NVARCHAR(255) NOT NULL,
)
GO
*/

SELECT * FROM PERSONAS;
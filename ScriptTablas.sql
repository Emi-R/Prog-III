Create Database AplicacionPersonas
Go

Use AplicacionPersonas
Go

Create Table EstadoCivil_X_ID(
	ID Tinyint Primary Key,
	Estado Varchar(10) Not Null,
)

Create Table Personas(
	DNI Varchar(50) Not Null Primary Key,
	Apellido Varchar(50) Not Null,
	Nombres Varchar(50) Not Null,
	FechaNac Date Not Null,
	EstadoCivil Tinyint Not Null Foreign Key References EstadoCivil_X_ID(ID),
	Sexo Varchar(1) Null,
)
Go
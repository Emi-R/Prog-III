Create Database AplicacionPersonas
Go

Use AplicacionPersonas
Go

Create Table Personas(
	DNI Varchar(50) Not Null Primary Key,
	Apellido Varchar(50) Not Null,
	Nombres Varchar(50) Not Null,
	FechaNac Date Not Null,
	EstadoCivil Tinyint Not Null,
	Sexo Bit Not Null,

)
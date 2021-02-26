/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 02-jun.-2020 18:15:39 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Alumno_Tel�fono]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Alumno] DROP CONSTRAINT [FK_Alumno_Tel�fono]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Alumno-Carrera_Alumno]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Alumno-Carrera] DROP CONSTRAINT [FK_Alumno-Carrera_Alumno]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Alumno-Carrera_Carrera]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Alumno-Carrera] DROP CONSTRAINT [FK_Alumno-Carrera_Carrera]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Alumno-Curso_Alumno]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Alumno-Curso] DROP CONSTRAINT [FK_Alumno-Curso_Alumno]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Alumno-Curso_Curso]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Alumno-Curso] DROP CONSTRAINT [FK_Alumno-Curso_Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Alumno-Materia_Alumno]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Alumno-Materia] DROP CONSTRAINT [FK_Alumno-Materia_Alumno]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Alumno-Materia_Materia]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Alumno-Materia] DROP CONSTRAINT [FK_Alumno-Materia_Materia]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Carrera_Curso]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Carrera] DROP CONSTRAINT [FK_Carrera_Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Carrera-Sede_Carrera]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Carrera-Sede] DROP CONSTRAINT [FK_Carrera-Sede_Carrera]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Carrera-Sede_Sede]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Carrera-Sede] DROP CONSTRAINT [FK_Carrera-Sede_Sede]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Cuota_Alumno]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Cuota] DROP CONSTRAINT [FK_Cuota_Alumno]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Curso_Materia]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Curso] DROP CONSTRAINT [FK_Curso_Materia]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Docente_Tel�fono]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Docente] DROP CONSTRAINT [FK_Docente_Tel�fono]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Ex�men_Alumno]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Ex�men] DROP CONSTRAINT [FK_Ex�men_Alumno]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Materia_Docente]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Materia] DROP CONSTRAINT [FK_Materia_Docente]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Materia_Ex�men]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Materia] DROP CONSTRAINT [FK_Materia_Ex�men]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Materia_Horario]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Materia] DROP CONSTRAINT [FK_Materia_Horario]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Alumno]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Alumno]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Alumno-Carrera]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Alumno-Carrera]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Alumno-Curso]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Alumno-Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Alumno-Materia]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Alumno-Materia]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Carrera]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Carrera]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Carrera-Sede]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Carrera-Sede]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Cuota]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Cuota]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Curso]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Curso]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Docente]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Docente]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Ex�men]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Ex�men]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Horario]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Horario]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Materia]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Materia]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Sede]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Sede]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Tel�fono]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Tel�fono]
GO

/* Create Tables */

CREATE TABLE [Alumno]
(
	[Legajo] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[Apellido] varchar(50) NULL,
	[Fecha_Nacimiento] datetime NULL,
	[Email] varchar(50) NULL,
	[Tel�fono_Id] int NULL
)
GO

CREATE TABLE [Alumno-Carrera]
(
	[Carrera_Id] int NULL,
	[Alumno_Legajo] int NULL
)
GO

CREATE TABLE [Alumno-Curso]
(
	[Curso_Id] int NULL,
	[Alumno_Legajo] int NULL
)
GO

CREATE TABLE [Alumno-Materia]
(
	[Alumno_Legajo] int NULL,
	[Materia_Id] int NULL
)
GO

CREATE TABLE [Carrera]
(
	[Id] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[Curso_Id] int NULL
)
GO

CREATE TABLE [Carrera-Sede]
(
	[Carrera_Id] int NULL,
	[Sede_Id] int NULL
)
GO

CREATE TABLE [Cuota]
(
	[Id] int NOT NULL,
	[Matr�cula] bit NULL,
	[Alumno_Legajo] int NULL
)
GO

CREATE TABLE [Curso]
(
	[Id] int NOT NULL,
	[Comision] varchar(50) NULL,
	[Turno] varchar(50) NULL,
	[A�o] int NULL,
	[Materia_Id] int NULL
)
GO

CREATE TABLE [Docente]
(
	[DNI] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[Apellido] varchar(50) NULL,
	[Fecha_Nacimiento] datetime NULL,
	[Email] varchar(50) NULL,
	[Cargo] varchar(50) NULL,
	[Fecha_Ingreso] datetime NULL,
	[Tel�fono_Id] int NULL
)
GO

CREATE TABLE [Ex�men]
(
	[Id] int NOT NULL,
	[Nota] decimal(18) NULL,
	[Cuatrimestre] int NULL,
	[Final] bit NULL,
	[Alumno_Legajo] int NULL
)
GO

CREATE TABLE [Horario]
(
	[Id] int NOT NULL,
	[Nombre] varchar(max) NULL,
	[HoraInicio] time(7) NULL,
	[HoraFin] time(7) NULL
)
GO

CREATE TABLE [Materia]
(
	[Id] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[Descripci�n] varchar(50) NULL,
	[Ex�men_Id] int NULL,
	[Horario_Id] int NULL,
	[Docente_DNI] int NULL
)
GO

CREATE TABLE [Sede]
(
	[Id] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[Direcci�n] varchar(50) NULL
)
GO

CREATE TABLE [Tel�fono]
(
	[Id] int NOT NULL,
	[N�mero] int NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Alumno] 
 ADD CONSTRAINT [PK_Alumno]
	PRIMARY KEY CLUSTERED ([Legajo] ASC)
GO

ALTER TABLE [Carrera] 
 ADD CONSTRAINT [PK_Carrera]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

ALTER TABLE [Cuota] 
 ADD CONSTRAINT [PK_Cuota]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

ALTER TABLE [Curso] 
 ADD CONSTRAINT [PK_Curso]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

ALTER TABLE [Docente] 
 ADD CONSTRAINT [PK_Docente]
	PRIMARY KEY CLUSTERED ([DNI] ASC)
GO

ALTER TABLE [Ex�men] 
 ADD CONSTRAINT [PK_Ex�men]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

ALTER TABLE [Horario] 
 ADD CONSTRAINT [PK_Horario]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

ALTER TABLE [Materia] 
 ADD CONSTRAINT [PK_Materia]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

ALTER TABLE [Sede] 
 ADD CONSTRAINT [PK_Sede]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

ALTER TABLE [Tel�fono] 
 ADD CONSTRAINT [PK_Tel�fono]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [Alumno] ADD CONSTRAINT [FK_Alumno_Tel�fono]
	FOREIGN KEY ([Tel�fono_Id]) REFERENCES [Tel�fono] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alumno-Carrera] ADD CONSTRAINT [FK_Alumno-Carrera_Alumno]
	FOREIGN KEY ([Alumno_Legajo]) REFERENCES [Alumno] ([Legajo]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alumno-Carrera] ADD CONSTRAINT [FK_Alumno-Carrera_Carrera]
	FOREIGN KEY ([Carrera_Id]) REFERENCES [Carrera] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alumno-Curso] ADD CONSTRAINT [FK_Alumno-Curso_Alumno]
	FOREIGN KEY ([Alumno_Legajo]) REFERENCES [Alumno] ([Legajo]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alumno-Curso] ADD CONSTRAINT [FK_Alumno-Curso_Curso]
	FOREIGN KEY ([Curso_Id]) REFERENCES [Curso] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alumno-Materia] ADD CONSTRAINT [FK_Alumno-Materia_Alumno]
	FOREIGN KEY ([Alumno_Legajo]) REFERENCES [Alumno] ([Legajo]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alumno-Materia] ADD CONSTRAINT [FK_Alumno-Materia_Materia]
	FOREIGN KEY ([Materia_Id]) REFERENCES [Materia] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Carrera] ADD CONSTRAINT [FK_Carrera_Curso]
	FOREIGN KEY ([Curso_Id]) REFERENCES [Curso] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Carrera-Sede] ADD CONSTRAINT [FK_Carrera-Sede_Carrera]
	FOREIGN KEY ([Carrera_Id]) REFERENCES [Carrera] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Carrera-Sede] ADD CONSTRAINT [FK_Carrera-Sede_Sede]
	FOREIGN KEY ([Sede_Id]) REFERENCES [Sede] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Cuota] ADD CONSTRAINT [FK_Cuota_Alumno]
	FOREIGN KEY ([Alumno_Legajo]) REFERENCES [Alumno] ([Legajo]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Curso] ADD CONSTRAINT [FK_Curso_Materia]
	FOREIGN KEY ([Materia_Id]) REFERENCES [Materia] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Docente] ADD CONSTRAINT [FK_Docente_Tel�fono]
	FOREIGN KEY ([Tel�fono_Id]) REFERENCES [Tel�fono] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Ex�men] ADD CONSTRAINT [FK_Ex�men_Alumno]
	FOREIGN KEY ([Alumno_Legajo]) REFERENCES [Alumno] ([Legajo]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Materia] ADD CONSTRAINT [FK_Materia_Docente]
	FOREIGN KEY ([Docente_DNI]) REFERENCES [Docente] ([DNI]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Materia] ADD CONSTRAINT [FK_Materia_Ex�men]
	FOREIGN KEY ([Ex�men_Id]) REFERENCES [Ex�men] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Materia] ADD CONSTRAINT [FK_Materia_Horario]
	FOREIGN KEY ([Horario_Id]) REFERENCES [Horario] ([Id]) ON DELETE No Action ON UPDATE No Action
GO
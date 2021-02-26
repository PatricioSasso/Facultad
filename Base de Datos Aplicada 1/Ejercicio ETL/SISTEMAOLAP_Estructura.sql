Use master 
go
--
if exists(select * from sysdatabases where name='SistemaOLAP')
drop database SistemaOLAP
go
--
create database SistemaOLAP
go
Use SistemaOLAP
go


create function dbo.fn_mes(@m int)returns varchar(15)
begin
	declare @mes table(codigo int,nombre varchar(15))
	insert @mes values(1,'Enero'),(2,'Febrero'),
	(3,'Marzo'),(4,'Abril'),(5,'Mayo'),(6,'Junio'),
	(7,'Julio'),(8,'Agosto'),(9,'Setiembre'),
	(10,'Octubre'),(11,'Noviembre'),(12,'Diciembre')
	return(select nombre from @mes where codigo=@m)
end
go
--
create function dbo.fn_diaSem(@d int)returns varchar(15)
begin
	declare @semana table(codigo int,nombre varchar(15))
	insert @semana values(1,'Lunes'),(2,'Martes'),
	(3,'Miércoles'),(4,'Jueves'),(5,'Viernes'),
	(6,'Sábado'),(7,'Domingo')
	return(select nombre from @semana where codigo=@d)
end
go


/*------------------------------UBIGEO---------------------------------------*/
create table DimUbigeo(
	Ubigeo_SKey int identity (1,1) primary key not null,
	IdDepartamento nchar(10) not null,
	NombreDepartamento nvarchar(50) not null,
	IdProvincia nchar(10) not null,
	NombreProvincia nvarchar(50) not null,
	IdDistrito nchar(10) not null,
	NombreDistrito nvarchar(50) not null);
--Select * from DimUbigeo
/*------------------------------CLIENTE---------------------------------------*/
create table DimCliente(
	ECliente int identity (1,1) primary key not null,
	IdCliente  nchar(6) not null,
	NombreCliente nvarchar(150) not null,
	IdDistrito nchar(10) not null,
	NombreDistrito nvarchar(50) not null,
	DniCliente nchar(8) not null);
--Select * from DimCliente
	
/*------------------------------EMPLEADO--------------------------------------*/
create table DimEmpleado(
	EEmpleado int identity (1,1)  primary key not null,
	IdEmpleado  nchar(6) not null,
	NombreEmpleado nvarchar(150) not null,
	IdDistrito nchar(10) not null,
	NombreDistrito nvarchar(50) not null,
	DniEmpleado nchar(8) not null);
--Select * from DimEmpleado
	
/*--------------------------------PRODUCTO----------------------------------*/
create table DimProducto(
	EProducto int identity (1,1) primary key not null,
	IdProducto nchar(6) not null,
	DescriProducto varchar(100) not null,
	IdMarca nchar(6) not null,
	NombreMarca nvarchar(50) not null,
	IdCategoria nchar(6) not null,
	NombreCategoria nvarchar(50) not null,
	PrecioUnidad money null);
--Select * from DimProducto
	
/*------------------------------TIEMPO--------------------------------------*/
create table DimTiempo (
	FechaId int primary key not null,
	Fecha datetime not null,
	Año smallint not null,
	Trimestre tinyint not null,
	Mes tinyint not null,
	NomMes varchar(15) not null,
	Dia tinyint not null,
	DiaSem tinyint not null,
	NomDiaSem varchar(15) not null);
--Select * from DimTiempo

/*------------------------------VentaOrden--------------------------------------*/
create table FactVentaOrden (
	ECliente int references DimCliente not null,
	EEmpleado int references DimEmpleado not null,
	Ubigeo_SKey int references DimUbigeo not null,
	EProducto int references DimProducto not null,
	FechaId int references DimTiempo not null,
	Total money not null);
--Select * from FactVentaOrden

--alter table DimProducto alter column DescriProducto nvarchar(100) not null


/*
------------------------------TABLA HECHOS CARGARVENTA--------------------------
create procedure USP_Carga_Venta
as
BEGIN
	insert into FactVentaOrden 
	(
	ECliente,EEmpleado,Ubigeo_SKey,EProducto,FechaId,Total
	)
	SELECT distinct
	  ECliente,EEmpleado,Ubigeo_SKey,EProducto,FechaId,(dord.PrecioUnidad*dord.Cantidad) as Total
	  FROM SistemaOLTP..Orden ord 
	  inner join SistemaOLTP..DetalleOrden dord on ord.IdOrden=dord.IdOrden
	  inner join DimCliente dc on dc.IdCliente=ord.IdCliente
	  inner join DimEmpleado de on de.IdEmpleado=ord.IdEmpleado
	  inner join DimUbigeo du on du.IdDistrito=ord.IdDistrito
	  inner join DimProducto dp on  dp.IdProducto=dord.IdProducto
	  inner join DimTiempo dti on dti.Fecha=ord.FechaPedido
	 WHERE (ord.FechaPedido IS NOT NULL)
END
go
*/


/*
------------------------------LIMPIAR TABLAS ETL--------------------------
EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
GO
EXEC sp_MSForEachTable 'ALTER TABLE ? DISABLE TRIGGER ALL'
GO
 
EXEC sp_MSForEachTable
    'BEGIN TRY
        TRUNCATE TABLE ?
    END TRY
    BEGIN CATCH
        DELETE FROM ?
    END CATCH;'
EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'
GO
EXEC sp_MSForEachTable 'ALTER TABLE ? ENABLE TRIGGER ALL'
GO

DBCC CHECKIDENT (DimUbigeo, RESEED,0)
DBCC CHECKIDENT (DimCliente, RESEED,0)
DBCC CHECKIDENT (DimEmpleado, RESEED,0)
DBCC CHECKIDENT (DimProducto, RESEED,0)
*/




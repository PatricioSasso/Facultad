Use master
go
--
if exists(select * from sysdatabases where name='SistemaOLTP')
drop database SistemaOLTP
go
--
create database SistemaOLTP
go
Use SistemaOLTP
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


/*--------------------------------DEPARTAMENTO--------------------------------*/
create table Departamento(
	IdDepartamento nchar(6) not null primary key,
	NombreDepartamento nvarchar(50) not null);
	
/*--------------------------------PROVINCIA-----------------------------------*/
create table Provincia(
	IdProvincia nchar(6) not null primary key,
	NombreProvincia nvarchar(50) not null,
	IdDepartamento nchar(6)foreign key references Departamento(IdDepartamento)not null);
	
/*---------------------------------DISTRIRO-----------------------------------*/
create table Distrito(
	IdDistrito nchar(7) not null primary key,
	NombreDistrito nvarchar(50) not null,
	IdProvincia nchar(6)foreign key references Provincia(IdProvincia)not null);
	
/*------------------------------CLIENTE---------------------------------------*/
create table Cliente(
	IdCliente nchar(6) primary key not null,
	ApellidoCliente nvarchar(50) not null,
	NombreCliente nvarchar(50) not null,
	DniCliente nchar(8) not null,
	IdDepartamento nchar(6)foreign key references Departamento(IdDepartamento) not null,
	IdProvincia nchar(6)foreign key references Provincia(IdProvincia) not null,
	IdDistrito nchar(7)foreign key references Distrito(IdDistrito) not null,
	MailCliente nvarchar(50) not null,
	TelCliente nvarchar(15) not null);

/*------------------------------CARGO-----------------------------------------*/
create table Cargo(
	IdCargo nchar(6) primary key not null,
	NombreCargo nvarchar(50) not null);
	
/*------------------------------EMPLEADO--------------------------------------*/
create table Empleado(
	IdEmpleado nchar(6) primary key not null,
	ApellidoEmpleado nvarchar(50) not null,
	NombreEmpleado nvarchar(50) not null,
	IdCargo nchar(6)foreign key references Cargo(IdCargo) not null,
	DniEmpleado nchar(8) not null,
	IdDepartamento nchar(6)foreign key references Departamento(IdDepartamento) not null,
	IdProvincia nchar(6)foreign key references Provincia(IdProvincia) not null,
	IdDistrito nchar(7)foreign key references Distrito(IdDistrito) not null,
	MailEmpleado nvarchar(50) not null,
	TelEmpleado nvarchar(15) not null)
	
/*------------------------------PROVEEDOR------------------------------------*/
create table Proveedor(
	IdProveedor nchar(6) primary key,
	NombreProveedor nvarchar(50) not null,
	RucProveedor nchar(11) not null,
	ApeliidoContacto nvarchar(50) not null,
	NombreContacto nvarchar(50) not null,
	DireProveedor nvarchar(50) not null,
	MailProveedor nvarchar(50) not null,
	TelProveedor nvarchar(15) not null);

/*------------------------------CATEGORIA------------------------------------*/
create table Categoria(
	IdCategoria nchar(6) primary key not null,
	NombreCategoria nvarchar(50) not null);

/*-------------------------------MARCA--------------------------------------*/
create table Marca(
	IdMarca nchar(6) primary key not null,
	NombreMarca nvarchar(50) not null);

/*-------------------------------PRODUCTO-----------------------------------*/
create table Producto(
	IdProducto nchar(6) primary key not null,
	DescriProducto varchar(50) not null,
	IdMarca nchar(6)foreign key references Marca(IdMarca) not null,
	IdProveedor nchar(6) foreign key references Proveedor(IdProveedor) not null,
	IdCategoria nchar(6) foreign key references Categoria(IdCategoria) not null,
	PrecioUnidad money  not null,
	UnidadesEnExistencia smallint  not null);
	

/*--------------------------------ORDEN-------------------------------------*/
create table Orden(
	IdOrden nchar(6) primary key not null,
	IdCliente nchar(6) foreign key references Cliente(IdCliente) not null,
	IdEmpleado nchar(6) foreign key references Empleado(IdEmpleado) not null,
	IdDistrito nchar(7) foreign key references Distrito (IdDistrito) not null,
	FechaPedido date not null,
	FechaEntrega date not null);

/*-----------------------------DETALLEORDEN----------------------------------*/
create table DetalleOrden(
	IdOrden nchar(6) foreign key references Orden(IdOrden) not null,
	IdProducto nchar(6) foreign key references Producto(IdProducto) not null,
	PrecioUnidad money not null,
	Cantidad smallint not null);
	

/*
-----------------------------CONSULTA TIEMPO-------------------------------
SELECT DISTINCT 
YEAR(FechaPedido) * 10000 + MONTH(FechaPedido) * 100 + DAY(FechaPedido) AS CodigoFecha,
FechaPedido, YEAR(FechaPedido) AS Año, 
DATEPART(QUARTER,FechaPedido) AS Trimestre, 
MONTH(FechaPedido) AS Mes, dbo.fn_mes(MONTH(FechaPedido)) AS NomMes, 
DAY(FechaPedido) AS Dia,
DATEPART(WEEKDAY,FechaPedido) AS DiaSemana,
dbo.fn_diaSem(DATEPART(WEEKDAY, FechaPedido)) AS NomDiaSemana
FROM dbo.Orden
*/
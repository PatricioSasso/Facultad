/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 16-sep.-2020 02:46:10 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[FK_ItemProducto_Pedido de Producción]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [dbo].[ItemProducto] DROP CONSTRAINT [FK_ItemProducto_Pedido de Producción]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[FK_Item_Producto]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [dbo].[ItemProducto] DROP CONSTRAINT [FK_Item_Producto]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[ItemProducto]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [dbo].[ItemProducto]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[Pedido de Producción]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [dbo].[Pedido de Producción]
GO

/* Create Tables */

CREATE TABLE [dbo].[ItemProducto]
(
	[PedidoProduccion_Id] int NOT NULL,
	[Cantidad] int NULL,
	[Producto_Id] int NOT NULL
)
GO

CREATE TABLE [dbo].[Pedido de Producción]
(
	[Id] int NOT NULL,
	[FechaProduccion] datetime NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [dbo].[ItemProducto] 
 ADD CONSTRAINT [PK_ItemProducto]
	PRIMARY KEY CLUSTERED ([PedidoProduccion_Id] ASC,[Producto_Id] ASC)
GO

ALTER TABLE [dbo].[Pedido de Producción] 
 ADD CONSTRAINT [PK_Pedido de Producción]
	PRIMARY KEY CLUSTERED ([Id] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [dbo].[ItemProducto] ADD CONSTRAINT [FK_ItemProducto_Pedido de Producción]
	FOREIGN KEY ([PedidoProduccion_Id]) REFERENCES [dbo].[Pedido de Producción] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [dbo].[ItemProducto] ADD CONSTRAINT [FK_Item_Producto]
	FOREIGN KEY ([Producto_Id]) REFERENCES [dbo].[Producto] ([Id]) ON DELETE No Action ON UPDATE No Action
GO

/*Ejercicio 1*/
Update Sales.SalesReason Set Sales.SalesReason.Name = 'Precio' Where SalesReasonID = 1
Update Sales.SalesReason Set Sales.SalesReason.Name = 'En Promocion', ModifiedDate = GETDATE() Where SalesReasonID = 2 
/*Ejercicio 2*/
Select * From Sales.SalesReason Where SalesReasonID = 1 Or SalesReasonID = 2
/*Ejercicio 3*/
Update Person.StateProvince Set TerritoryID = 8 Where CountryRegionCode = 'AR'
/*Ejercicio 4*/
Select * From Person.StateProvince Where CountryRegionCode = 'AR'



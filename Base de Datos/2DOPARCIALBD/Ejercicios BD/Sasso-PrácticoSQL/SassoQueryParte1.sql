/*Ejercicio 1*/
Select * From Production.Product Order By Production.Product.Name Asc
/*Ejercicio 2*/
Select * From Production.Product Where ProductSubcategoryID = 1
/*Ejercicio 3*/
Select ProductId As 'Codigo', Production.Product.Name As 'Nombre', ProductNumber As 'NumeroProducto' From Production.Product
/*Ejercicio 4*/
Select * From Production.Product Where ListPrice Between 500 And 1000 Order by ListPrice Desc
/*Ejercicio 5*/
Select * From Production.Product Where ProductNumber Like 'LJ%'
/*Ejercicio 6*/
Select * From Production.Product Where Color = 'White' Or Color = 'Black'
/*Ejercicio 7*/
Select * From Production.Product Where Color is Null
/*Ejercicio 8*/
Select Color From Production.Product Group By Color
/*Ejercicio 9*/
Select  ListPrice, StandardCost, ListPrice - StandardCost As 'Margen' From Production.Product Order by ListPrice Desc
/*Ejercicio 10*/
Select Top 10 ListPrice From Production.Product Order by ListPrice Desc
/*Ejercicio 11*/
Select * From (Select Count(ProductSubcategoryID) As 'SubCategoria'From Production.Product Group by ProductSubcategoryID) Tabla2 Where SubCategoria > 20


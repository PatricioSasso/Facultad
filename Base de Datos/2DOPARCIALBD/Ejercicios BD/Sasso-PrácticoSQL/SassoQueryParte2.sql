/*Ejercicio 1*/
Execute sp_help 'Person.StateProvince'
/*Ejercicio 2*/
Select * From Person.StateProvince
Insert Into Person.StateProvince (StateProvinceCode, Person.StateProvince.Name, CountryRegionCode, TerritoryID)
Values ('BA', 'Buenos Aires', 'AR',1), ('CO', 'Cordoba', 'AR',1), ('MZ', 'Mendoza', 'AR',1)
/*Ejercicio 3*/
Select Top 1 * From Person.StateProvince Order By StateProvinceID Desc
/*Ejercicio 4*/
Select * From Person.StateProvince Where CountryRegionCode = 'AR'


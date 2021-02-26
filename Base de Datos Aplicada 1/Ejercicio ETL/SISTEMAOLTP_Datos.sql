Use SistemaOLTP
go
/*------------------------------DEPARTAMENTO---------------------------------------*/
insert into Departamento values
('DEP007','CALLAO'),('DEP015','LIMA');
--select * from departamento

/*------------------------------PROVINCIA---------------------------------------*/
insert into provincia values
('PRV066','CALLAO','DEP007'),('PRV127','LIMA','DEP015');
--select * from provincia

/*------------------------------DISTRITO---------------------------------------*/
insert into Distrito values
('DIS0659','CALLAO','PRV066'),('DIS0660','BELLAVISTA','PRV066'),('DIS0661','CARMEN DE LA LEGUA REYNOSO','PRV066'),
('DIS0662','LA PERLA','PRV066'),('DIS0663','LA PUNTA','PRV066'),('DIS0664','VENTANILLA','PRV066'),
('DIS1223','LIMA','PRV127'),('DIS1224','ANCON','PRV127'),('DIS1225','ATE','PRV127'),
('DIS1226','BARRANCO','PRV127'),('DIS1227','BREÑA','PRV127'),('DIS1228','CARABAYLLO','PRV127'),('DIS1229','CHACLACAYO','PRV127'),
('DIS1230','CHORRILLOS','PRV127'),('DIS1231','CIENEGUILLA','PRV127'),('DIS1232','COMAS','PRV127'),('DIS1233','EL AGUSTINO','PRV127'),
('DIS1234','INDEPENDENCIA','PRV127'),('DIS1235','JESUS MARIA','PRV127'),('DIS1236','LA MOLINA','PRV127'),('DIS1237','LA VICTORIA','PRV127'),
('DIS1238','LINCE','PRV127'),('DIS1239','LOS OLIVOS','PRV127'),('DIS1240','LURIGANCHO','PRV127'),('DIS1241','LURIN','PRV127'),
('DIS1242','MAGDALENA DEL MAR','PRV127'),('DIS1243','MAGDALENA VIEJA','PRV127'),('DIS1244','MIRAFLORES','PRV127'),
('DIS1245','PACHACAMAC','PRV127'),('DIS1246','PUCUSANA','PRV127'),('DIS1247','PUENTE PIEDRA','PRV127'),('DIS1248','PUNTA HERMOSA','PRV127'),
('DIS1249','PUNTA NEGRA','PRV127'),('DIS1250','RIMAC','PRV127'),('DIS1251','SAN BARTOLO','PRV127'),('DIS1252','SAN BORJA','PRV127'),
('DIS1253','SAN ISIDRO','PRV127'),('DIS1254','SAN JUAN DE LURIGANCHO','PRV127'),('DIS1255','SAN JUAN DE MIRAFLORES','PRV127'),
('DIS1256','SAN LUIS','PRV127'),('DIS1257','SAN MARTIN DE PORRES','PRV127'),('DIS1258','SAN MIGUEL','PRV127'),('DIS1259','SANTA ANITA','PRV127'),
('DIS1260','SANTA MARIA DEL MAR','PRV127'),('DIS1261','SANTA ROSA','PRV127'),('DIS1262','SANTIAGO DE SURCO','PRV127'),('DIS1263','SURQUILLO','PRV127'),
('DIS1264','VILLA EL SALVADOR','PRV127'),('DIS1265','VILLA MARIA DEL TRIUNFO','PRV127');
--select * from distrito

/*------------------------------CLIENTE---------------------------------------*/
insert into Cliente values
('CL0001','Morales Biminchumo','Jack Anthony','76543210','DEP007','PRV066','DIS0659','jmorales@hotmail.com','987654321'),
('CL0002','Rios Llocclla','Leonardo Esteban','76543201','DEP007','PRV066','DIS0659','jrios@hotmail.com','987654312');
--select * from Cliente

/*------------------------------CARGO-----------------------------------------*/
insert into Cargo values
('CAR001','Encargado De Ventas'),
('CAR002','Encargado De Almacen'),
('CAR003','Soporte Tecnico');
--select * from Cargo
/*------------------------------EMPLEADO--------------------------------------*/
insert into Empleado values
('EMP001','Rios Saldarriaga','Sony Omar','CAR002','78914506','DEP007','PRV066','DIS0659','jack14_sdb@hotmail.com','940466780'),
('EMP002','Morales Biminchumo','Jack Atnhony','CAR003','72328282','DEP007','PRV066','DIS0659','jack14_sdb@hotmail.com','940466780');
--select * from Empleado
/*------------------------------PROVEEDOR------------------------------------*/
insert into Proveedor values
('PVD001','Casa sac','20455345619','Payesa Del Rio','Marcos Junnior','Chile','mpayesa@respaldo.com','987654321'),
('PVD002','IDAT PERÚ sac','20455345619','Bucho Ñopo','Jean Eder','Chile','jbucho@intelecperu.com','987654321');
--select * from Proveedor

/*------------------------------CATEGORIA------------------------------------*/
insert into Categoria values
('CTG001','Laptops');
--select * from Categoria	
/*-------------------------------MARCA--------------------------------------*/
insert into Marca values
('MRC001','Toshiba'),
('MRC002','Hp');
--select * from Marca
/*-------------------------------PRODUCTO-----------------------------------*/
insert into Producto values
('PR0001','TOSHIBA LAPTOP S45-A4111SL','MRC001','PVD002','CTG001',2899.00,10),
('PR0002','TOSHIBA LAPTOP P55-A5104SL','MRC001','PVD002','CTG001',4199.00,5);
--select * from Producto
/*--------------------------------ORDEN-------------------------------------*/
insert into Orden values
('OD0001','CL0001','EMP001','DIS0659','2014-03-01','2014-03-02'),
('OD0002','CL0002','EMP002','DIS0659','2014-03-02','2014-03-05');
--select * from Orden
/*-----------------------------DETALLEORDEN----------------------------------*/
insert into DetalleOrden values
('OD0001','PR0001',2899.00,2),
('OD0002','PR0002',4199.00,1);
--select * from DetalleOrden
--delete DetalleOrden;









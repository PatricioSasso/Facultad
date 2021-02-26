Select Alumno.Nombre, Apellido, Comision, Cuatrimestre, Materia.Nombre, AVG(Nota) as 'Promedio'
from Exámen 
INNER JOIN Curso ON Curso_Id = Curso.Id 
INNER JOIN Alumno ON Alumno_Legajo = Legajo 
INNER JOIN Materia ON Materia_Id = Materia.Id
where Alumno_Legajo = 1 AND Materia_Id = 1 AND Cuatrimestre = 1 AND Tipo = 'Parcial'
group by Alumno.Nombre, Apellido, Comision, Cuatrimestre, Materia.Nombre
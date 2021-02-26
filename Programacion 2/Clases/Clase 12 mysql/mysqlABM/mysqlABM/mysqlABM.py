import pymysql

def TestConnection():
	try:
		conexion = pymysql.connect(host='localhost',
			                     user='root',
				                 password='1234',
					             db='peliculas')
		print("Conexión correcta")
	except (pymysql.err.OperationalError, pymysql.err.InternalError) as e:
		print("Ocurrió un error al conectar: ", e)

def InsertPelicula(titulo, anio):
		conexion = pymysql.connect(host='localhost',
		                     user='root',
			                 password='1234',
				             db='peliculas')
		with conexion.cursor() as cursor:
			consulta = "INSERT INTO peliculas(titulo, anio) VALUES (%s, %s);"
			cursor.execute(consulta, (titulo, int(anio)))
		conexion.commit()
		conexion.close()
		print("Se agregó la película " + titulo + " correctamente")

def GetAllPeliculas():
		conexion = pymysql.connect(host='localhost',
	                     user='root',
		                 password='1234',
			             db='peliculas')
		with conexion.cursor() as cursor:
			cursor.execute("SELECT * FROM peliculas;")
			peliculas = cursor.fetchall()
			for pelicula in peliculas:
				print(pelicula)

TestConnection()
titulo = input("Ingrese el título de la película a agregar : ")
anio = input("Ingrese el año de estreno de la película a agregar : ")
"""InsertPelicula(titulo, anio)"""
GetAllPeliculas()

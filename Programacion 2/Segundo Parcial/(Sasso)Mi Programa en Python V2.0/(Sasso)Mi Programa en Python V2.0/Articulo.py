class Articulo:
    def __init__(self, codigo, descripcion, stock):
        self.__codigo = codigo
        self.setDescripcion(descripcion)
        self.setStock(stock)

    def getCodigo(self):
        return self.__codigo

    def getDescripcion(self):
        return self.__descripcion
    def setDescripcion(self,value):
        self.__descripcion = value

    def getStock(self):
        return self.__stock
    def setStock(self,value):
        self.__stock = value

    def escribir(self):
        f = open("Articulos.txt", "a")
        f.write(self.getCodigo() + "," + self.getDescripcion() + "," + str(self.getStock()) + "\n")
        f.close()

    def sobreEscribir(self, lista):
        f = open("Articulos.txt","w")
        for articulo in lista:
            f.write(articulo.getCodigo() + "," + articulo.getDescripcion() + "," + str(articulo.getStock()) + "\n")
        f.close()

    @classmethod
    def getList(self):
        lista = []
        f = open("Articulos.txt","r")
        for linea in f:
            separado = str(linea).split(',')
            lista.append(Articulo(separado[0], separado[1], separado[2].replace("\n","")))
        f.close()
        return lista
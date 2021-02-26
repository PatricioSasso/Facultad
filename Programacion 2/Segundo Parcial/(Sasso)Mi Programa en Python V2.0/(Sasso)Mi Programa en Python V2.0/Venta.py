class Venta:
    def __init__(self, id, fecha, codigoArticulo, vendedor, sucursal, importeVendido):
        self.__id = id
        self.setFecha(fecha)
        self.setCodigoArticulo(codigoArticulo)
        self.setVendedor(vendedor)
        self.setSucursal(sucursal)
        self.setImporteVendido(importeVendido)

    def getId(self):
        return self.__id

    def getFecha(self):
        return self.__fecha
    def setFecha(self, value):
        self.__fecha = value

    def getCodigoArticulo(self):
        return self.__codigoArticulo
    def setCodigoArticulo(self,value):
        self.__codigoArticulo = value

    def getVendedor(self):
        return self.__vendedor
    def setVendedor(self,value):
        self.__vendedor = value

    def getSucursal(self):
        return self.__sucursal
    def setSucursal(self,value):
        self.__sucursal = value

    def getImporteVendido(self):
        return self.__importeVendido
    def setImporteVendido(self, value):
        self.__importeVendido = value

    def escribir(self):
        f = open("Ventas.txt","a")
        f.write(str(self.getId()) + "," + self.getFecha() + "," + self.getCodigoArticulo() + "," + self.getVendedor() + "," + self.getSucursal() + "," + str(self.getImporteVendido()) + "\n")
        f.close()

    def sobreEscribir(self, lista):
        f = open("Ventas.txt","w")
        for venta in lista:
            f.write(str(venta.getId()) + "," + venta.getFecha() + "," + venta.getCodigoArticulo() + "," + venta.getVendedor() + "," + venta.getSucursal() + "," + str(venta.getImporteVendido()) + "\n")
        f.close()

    @classmethod
    def getList(self):
        lista = []
        f = open("Ventas.txt","r")
        for linea in f:
            separado = str(linea).split(',')
            lista.append(Venta(int(separado[0]), separado[1], separado[2], separado[3], separado[4], float(separado[5].replace("\n",""))))
        f.close()
        return lista
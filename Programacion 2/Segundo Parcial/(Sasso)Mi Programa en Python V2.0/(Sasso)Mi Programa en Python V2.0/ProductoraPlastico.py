import re, os, datetime
from Articulo import Articulo
from Venta import Venta
from Graficos import Graficos

class ProductoraPlastico:
    def __init__(self):
        if(os.path.exists("Articulos.txt") == False):
            f = open("Articulos.txt", "x")
            f.close()
        if(os.path.exists("Ventas.txt") == False):
            f = open("Ventas.txt", "x")
            f.close()
        self.setArticulos(Articulo.getList())
        self.setVentas(Venta.getList())

    def getArticulos(self):
        return self.__articulos
    def setArticulos(self, value):
        self.__articulos = value

    def getVentas(self):
        return self.__ventas
    def setVentas(self, value):
        self.__ventas = value

    def altaArticulo(self):
        codigo = input("Ingrese el código del artículo a agregar (Formato : A999) : ").upper()
        if (re.search("^[A-Za-z]\d{3}$", codigo)):
            alta = next((a for a in self.getArticulos() if a.getCodigo() == codigo), None)
            if(alta == None):
                descripcion = input("Ingrese la descripción del artículo a agregar : ")
                stock = int(input("Ingrese el stock del artículo a agregar : "))
                if(stock > 0):
                    alta = Articulo(codigo, descripcion, stock)
                    self.__articulos.append(alta)
                    alta.escribir()
                else:
                    raise Exception("No se puede crear un artículo con stock negativo")
            else:
                raise Exception("El artículo que desea ingresar ya existe")
        else:
            raise Exception("El formato del código es incorrecto, un ejemplo del formato es A999")

    def modificarArticulo(self):
        codigo = input("Ingrese el código del artículo a modificar (Formato : A999): ").upper()
        modificar = next((a for a in self.getArticulos() if a.getCodigo() == codigo), None)
        if(modificar != None):
            modificar.setDescripcion(input("Ingrese la nueva descripción del artículo : "))
            stock = int(input("Ingrese el stock del artículo a agregar : "))
            if(stock > 0):
                modificar.setStock(stock)
                modificar.sobreEscribir(self.getArticulos())
            else:
                raise Exception("No se puece crear un artículo con stock negativo")
        else:
            raise Exception("El artículo que desea ingresar no existe")

    def bajaArticulo(self):
        codigo = input("Ingrese el código del artículo a eliminar (Formato : A999) : ").upper()
        baja = next((a for a in self.getArticulos() if a.getCodigo() == codigo), None)
        if(baja != None):
            self.getArticulos().remove(baja)
            baja.sobreEscribir(self.getArticulos())
        else:
            raise Exception("El artículo que desea ingresar no existe")

    def altaVenta(self):
        id = int(input("Ingrese el id de la venta a agregar : "))
        if(id > 0):
            alta = next((a for a in self.getVentas() if a.getId() == id), None)
            if(alta == None):
                fecha = datetime.date.today().strftime("%d/%m/%Y")
                codigoArticulo = input("Ingrese el código del artículo vendido (Formato A999) : ").upper()
                articulo = next((a for a in self.getArticulos() if a.getCodigo() == codigoArticulo), None)
                if(articulo != None):
                    vendedor = input("Ingrese el nombre del vendedor : ")
                    sucursal = input("Ingrese el codigo de la sucursal (Formato : AAA999) : ").upper()
                    if(re.search("^[A-Za-z]{3}\d{3}$", sucursal)):
                        importeVendido = float(input("Ingrese el importe vendido total del artículo : "))
                        if(importeVendido > 0):
                            alta = Venta(id, fecha, codigoArticulo, vendedor, sucursal, importeVendido)
                            self.getVentas().append(alta)
                            alta.escribir()
                        else:
                            raise Exception("El importe vendido no puede ser negativo")
                    else:
                        raise Exception("El código de la sucursal no cumple con el formato AAA999")
                else:
                    raise Exception("El artículo que desea ingresar no existe")
            else:
                raise Exception("La venta que desea ingresar ya existe")
        else:
            raise Exception("El Id no puede ser negativo")

    def modificarVenta(self):
        id = int(input("Ingrese el id de la venta a modificar : "))
        modificar = next((a for a in self.getVentas() if a.getId() == id), None)
        if(modificar != None):
            fecha = input("Ingrese la nueva fecha con formato DD/MM/YYYY : ")
            if(re.search("^([0-2][0-9]|3[0-1])[/](0[0-9]|1[0-2])[/]\d{4}$", fecha) != None):
                modificar.setFecha(fecha)
                codigoArticulo = input("Ingrese el nuevo código de artículo (Formato: A999) : ").upper()
                articulo = next((a for a in self.getArticulos() if a.getCodigo() == codigoArticulo), None)
                if(articulo != None):
                    modificar.setCodigoArticulo(codigoArticulo)
                    modificar.setVendedor(input("Ingrese el nombre del nuevo vendedor : "))
                    sucursal = input("Ingrese el nuevo codigo de la sucursal (Formato : AAA999) : ").upper()
                    if(re.search("^[A-Za-z]{3}\d{3}$", sucursal)):
                        modificar.setSucursal(sucursal)
                        importeVendido = float(input("Ingrese el nuevo importe vendido total del artículo : "))
                        if(importeVendido > 0):
                            modificar.setImporteVendido(importeVendido)
                            modificar.sobreEscribir(self.getVentas())
                        else:
                            raise Exception("El importe vendido no puede ser negativo")
                    else:
                        raise Exception("El código de la sucursal no cumple con el formato AAA999")
                else:
                    raise Exception("El código del artículo no cumple con el formato A999")
            else:
                raise Exception("El formato de la fecha ingresada es incorrecto")
        else:
            raise Exception("La venta que desea ingresar no existe")

    def bajaVenta(self):
        id = int(input("Ingrese el id de la venta a eliminar : "))
        baja = next((a for a in self.getVentas() if a.getId() == id), None)
        if(baja != None):
            self.getVentas().remove(baja)
            baja.sobreEscribir(self.getVentas())
        else:
            raise Exception("La venta que desea ingresar no existe")

    def generarReporte(self):
        ventas = Venta.getList()
        totalGeneral = 0
        for venta in ventas :
            sucursal = venta.getSucursal()
            if sucursal != "":
                print("Sucursal : " + sucursal)
                ventasSucursal = [s for s in ventas if s.getSucursal() == sucursal]
                totalSucursal = 0
                for vSucursal in ventasSucursal:
                    if(vSucursal.getCodigoArticulo() != ""):
                        articulo = vSucursal.getCodigoArticulo()
                        descripcionArticulo = next((a for a in self.getArticulos() if a.getCodigo() == articulo), None)
                        print("           Artículo (Descripción) : " + descripcionArticulo.getDescripcion())
                        ventasArticulo = [a for a in ventasSucursal if a.getCodigoArticulo() == articulo]
                        total = 0
                        for vArticulo in ventasArticulo:
                            if(vArticulo.getImporteVendido() != 0):
                                ventasVendedor = [a for a in ventasArticulo if a.getVendedor() == vArticulo.getVendedor()]
                                totalVendedor = 0
                                for vVendedor in ventasVendedor:
                                    totalVendedor += vVendedor.getImporteVendido()
                                    vVendedor.setImporteVendido(0)
                                print("                                    Vendedor : " + vArticulo.getVendedor() + "    Importe : $" + str(totalVendedor))
                                total += totalVendedor
                            vArticulo.setCodigoArticulo("")
                            vArticulo.setSucursal("")
                        print("                                                                   Total : $" + str(total))
                        totalSucursal += total
                if(totalSucursal != 0):
                       print("                                                                               Total Sucursal : $" + str(totalSucursal))
                       totalGeneral+= totalSucursal
        print("\n                                                                                                 Total General : $" + str(totalGeneral))
        print("")

    def barrasSucursal(self):
        dicSucursales = dict()
        for venta in self.getVentas():
            keySucursal = venta.getSucursal()
            if(dicSucursales.get(keySucursal) == None):
                dicSucursales[keySucursal] = venta.getImporteVendido()
            else:
                dicSucursales[keySucursal] = dicSucursales[keySucursal] + venta.getImporteVendido()
        Graficos.GraficarBarras(dicSucursales, "Gráfico de barras - Ventas totales por sucursal")

    def barrasVendedor(self):
        dicVendedor = dict()
        for venta in self.getVentas():
            keyVendedor = venta.getVendedor()
            if(dicVendedor.get(keyVendedor) == None):
                dicVendedor[keyVendedor] = venta.getImporteVendido()
            else:
                dicVendedor[keyVendedor] = dicVendedor[keyVendedor] + venta.getImporteVendido()
        Graficos.GraficarBarras(dicVendedor, "Gráfico de barras - Ventas totales por vendedor")

    def barrasProducto(self):
        dicArticulo = dict()
        for venta in self.getVentas():
            keyArticulo = venta.getCodigoArticulo()
            if(dicArticulo.get(keyArticulo) == None):
                dicArticulo[keyArticulo] = venta.getImporteVendido()
            else:
                dicArticulo[keyArticulo] = dicArticulo[keyArticulo] + venta.getImporteVendido()
        Graficos.GraficarBarras(dicArticulo, "Gráfico de barras - Ventas totales por artículo")

    def mostrarArticulos(self):
        print("Los artículos listados son : ")
        for a in self.getArticulos():
            print("Código : " + a.getCodigo() + " , Descripción : " + a.getDescripcion() + " , Stock : " + str(a.getStock()))
        print("")

    def mostrarVentas(self):
        print("Las ventas listadas son : ")
        for v in self.getVentas():
            print("Id : " + str(v.getId()) + " , Fecha: " + v.getFecha() + " , Código de artículo : " + v.getCodigoArticulo() + " , Vendedor : " + v.getVendedor() + " , Sucursal : " + v.getSucursal() + " , Importe : $" + str(v.getImporteVendido()))
        print("")
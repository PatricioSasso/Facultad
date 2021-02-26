from ProductoraPlastico import ProductoraPlastico
import os

def mostrarMenu():
    print("||||||||||||||||||||||||||||||||||||||| Menu principal |||||||||||||||||||||||||||||||||||")
    print("1.   Dar de alta un Articulo")
    print("2.   Modificar un Articulo")
    print("3.   Dar de baja un Articulo")
    print("4.   Dar de alta una Venta")
    print("5.   Modificar una Venta")
    print("6.   Dar de baja una Venta")
    print("7.   Listar Artículos")
    print("8.   Listar Ventas")
    print("9.   Reporte")
    print("10.  Gráfico de Barras según el total vendido por Sucursal")
    print("11.  Gráfico de Barras según el total vendido por Vendedor")
    print("12.  Gráfico de Barras según el total vendido por Artículo")
    print("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
    return input("Ingrese el número correspondiente a la acción a realizar : ") 

os.system('cls')
Productora = ProductoraPlastico()
while True:
    try:
        while True:
            decision = mostrarMenu()
            print("")
            if(decision == "1"):
                Productora.mostrarArticulos()
                Productora.altaArticulo()
            elif(decision == "2"):
                Productora.mostrarArticulos()
                Productora.modificarArticulo()
            elif(decision == "3"):
                Productora.mostrarArticulos()
                Productora.bajaArticulo()
            elif(decision == "4"):
                Productora.mostrarVentas()
                Productora.mostrarArticulos()
                Productora.altaVenta()
            elif(decision == "5"):
                Productora.mostrarVentas()
                Productora.mostrarArticulos()
                Productora.modificarVenta()
            elif(decision == "6"):
                Productora.mostrarVentas()
                Productora.bajaVenta()
            elif(decision == "7"):
                Productora.mostrarArticulos()
            elif(decision == "8"):
                Productora.mostrarVentas()
            elif(decision == "9"):
                Productora.generarReporte()
            elif(decision == "10"):
                Productora.barrasSucursal()
            elif(decision == "11"):
                Productora.barrasVendedor()
            elif(decision == "12"):
                Productora.barrasProducto()
            input("Presione Enter para continuar ...")
            os.system('cls')
    except Exception as e:
        print(e.args)
        input("Presione Enter para continuar ...")
        os.system('cls')
import os
import clases as c

print("Bienvenido al supermercado El Chino")
cantidadCajas = int(input("Ingrese la cantidad de cajas del supermercado : "))
cajas = []
for i in range(cantidadCajas):
    cajas.append(c.Caja(i,[],[]))
supermercado = c.Supermercado(cajas)
decision = 0

while True:
    print("*************** Menu ***************")
    print("1.   Encolar Cliente")
    print("2.   Cobrar")
    print("3.   Salir")
    decision = input("Elija alguna de las opciones : ")
    if(decision == "1"):
        supermercado.mostrarCajas()
        seleccionada = int(input("Seleccione una caja : "))
        cliente = c.Cliente(0, "", 0)
        cliente.dni = int(input("Ingrese el dni del cliente: "))
        cliente.nombre = input("Ingrese el nombre del cliente : ")
        cliente.monto = float(input("Ingrese el monto a pagar del cliente : "))
        supermercado.encolarEnCaja(seleccionada, cliente)
    if(decision == "2"):
        supermercado.mostrarCajas()
        seleccionada = int(input("Seleccione una caja : "))
        supermercado.cajas[seleccionada].cobrar()
    if(decision == "3"): 
        break
    #print("\n" * 100)
print("**************************************")
print("Resultados:")
for caja in supermercado.cajas:
    print("Caja : " + str(caja.id))
    print("Total cobrado : " + str(caja.totalMontoCobrados()))
    print("Clientes cobrados : " + str(caja.totalClientesCobrados()))
    print("Total por cobrar : " + str(caja.totalMontoPorCobrar()))
    print("Clientes por cobrar : " + str(caja.totalClientesPorCobrar()))
    print("**********************************")
print("Total:")
print("Total cobrado : " + str(supermercado.totalMontoCobrados()))
print("Clientes cobrados : " + str(supermercado.totalClientesCobrados()))
print("Total por cobrar : " + str(supermercado.totalMontoPorCobrar()))
print("Clientes por cobrar : " + str(supermercado.totalClientesPorCobrar()))

import EntidadFinanciera as Entidad

def mostrarMenu():
    print("||||||||||||||||||||||||||||||||||||||| Menu principal |||||||||||||||||||||||||||||||||||")
    print("1.   Dar de alta un Titular")
    print("2.   Modificar un Titular")
    print("3.   Dar de baja un Titular")
    print("4.   Dar de alta una Tarjeta de Crédito")
    print("5.   Modificar una Tarjeta de Crédito")
    print("6.   Dar de baja una Tarjeta de Crédito")
    print("7.   Agregar una Tarjeta de Crédito a un Titular")
    print("8.   Quitar una Tarjeta de Crédito a un Titular")
    print("9.   Aplicar consumo en pesos")
    print("10.  Aplicar consumo en dólares")
    print("11.  Pagar tarjeta en pesos")
    print("12.  Pagar tarjeta en dólares")
    print("13.  Mostrar todos los titulares")
    print("14.  Mostrar todas las tarjetas disponibles")
    print("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
    return input("Ingrese el número correspondiente a la acción a realizar : ")

while True:
    try:
        while True:
            decision = mostrarMenu()
            print("\n")
            if(decision == "1"):
                entidad.altaTitular()
            elif(decision == "2"):
                entidad.modificarTitular()
            elif(decision == "3"):
                entidad.bajaTitular()
            elif(decision == "4"):
                entidad.altaTarjetaCredito()
            elif(decision == "5"):
                entidad.modificarTarjetaCredito()
            elif(decision == "6"):
                entidad.bajaTarjetaCredito()
            elif(decision == "7"):
                entidad.asignarTarjeta()
            elif(decision == "8"):
                entidad.quitarTarjeta()
            elif(decision == "9"):
                entidad.consumo("Peso")
            elif(decision == "10"):
                entidad.consumo("dolares")
            elif(decision == "11"):
                entidad.pago("Peso")
            elif(decision == "12"):
                entidad.pago("Dolar")
            elif(decision == "13"):
                entidad.mostrarTitulares()
            elif(decision == "14"):
                entidad.mostrarTarjetasDisponibles()
            input("Presione Enter para continuar ...")
            print("\n" * 30)
    except Exception as e:
        print(e.args)
        print("\n")
    
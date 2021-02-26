import re
import datetime
import Titular
import TarjetaCredito

class EntidadFinanciera:
    def __init__(self):
        self.set_tarjetas([])
        self.set_titulares([])

    def get_tarjetas(self):
        return self.__tarjetas
    def set_tarjetas(self, value):
        self.__tarjetas = value

    def get_titulares(self):
        return self.__titulares
    def set_titulares(self, value):
        self.__titulares = value

    def altaTitular(self):
        tipo = self.opcionesTipoDNI()
        dni = input("Ingrese el dni del Titular : ")
        if (tipo == "DNI" and re.search("\d{8}", dni) != None):
            alta = next((t for t in self.get_titulares() if (t.get_tipo() == tipo and t.get_dni() == dni)), None)
            if (alta == None):
                nombre = input("Ingrese el nombre del Titular : ")
                apellido = input("Ingrese el apellido del Titular : ")
                alta = Titular.Titular(tipo, dni, nombre, apellido)
                self.get_titulares().append(alta)
                alta.mostrar()
            else:
                print("El Titular que desea dar de alta ya existe")
        else:
            raise Exception("El formato del DNI es incorreto, deben ser 8 números ... Por ejemplo: 99999999")

    def modificarTitular(self):
        self.mostrarTitulares()
        tipo = self.opcionesTipoDNI()
        dni = input("Ingrese el dni del titular que desea modificar : ")
        modificar = next((t for t in self.get_titulares() if (t.get_tipo() == tipo and t.get_dni() == dni)), None)
        if (modificar != None):
            nombre = input("Ingrese el nuevo nombre del titular : ")
            apellido = input("Ingrese el nuevo apellido del titular : ")
            modificar.modificar(Titular.Titular(tipo, dni, nombre, apellido))
            modificar.mostrar()
        else:
            print("El titular seleccionado no existe")

    def bajaTitular(self):
        self.mostrarTitulares()
        tipo = self.opcionesTipoDNI()
        dni = input("Ingrese el dni del titular : ")
        baja = next((t for t in self.get_titulares() if (t.get_tipo() == tipo and t.get_dni() == dni)), None)
        if (baja != None):
            self.get_titulares().remove(baja)
            baja.baja()
        else:
            print("El titular seleccionado no existe")

    def altaTarjetaCredito(self):
        tipo = self.opcionesTipoTarjeta()
        if(tipo == "Platinium"):
           numero = "9999"
        elif(tipo == "Gold"):
           numero = "8888"
        else:
           numero = "7777"
        numero = numero + input("Ingrese el numero de la tarjeta de crédito : " + numero)
        if (re.search("\d{16}", numero) != None):
            alta = next((t for t in self.get_tarjetas() if (t.get_numero() == numero and t.get_tipo() == tipo)), None)
            if (alta == None):
                fechaOtorgamiento = datetime.datetime.now()
                fechaVencimiento = fechaOtorgamiento + datetime.timedelta(days = 730);
                limitePesos = float(input("Ingrese el límite en pesos de la tarjeta : "))
                if(limitePesos * -1 > 0 ):
                    raise Exception("El limite en pesos debe ser positivo")
                limiteDolares = float(input("Ingrese el límite en dolares de la tarjeta : "))
                if(limiteDolares * -1 > 0 ):
                    raise Exception("El limite en dolares debe ser positivo")
                alta = TarjetaCredito.TarjetaCredito(tipo, numero, fechaOtorgamiento, fechaVencimiento, limitePesos, limiteDolares)
                self.get_tarjetas().append(alta)
                print(alta.mostrar())
            else:
                print("La Tarjeta de Crédito que desea dar de alta ya existe")
        else:
            raise Exception("El formato de la tarjeta es incorrecto, deben ser 16 números ... Por ejemplo: 9999999999999999")

    def modificarTarjetaCredito(self):
        self.mostrarTarjetasDisponibles()
        numero = input("Ingrese el número de la tarjeta de crédito que desea modificar : ")
        modificar = next((t for t in self.get_tarjetas() if (t.get_numero() == numero)), None)
        if (modificar != None):
            fechaOtorgamiento = input("Ingrese la nueva fecha de otorgamiento de la tarjeta de crédito en formato MM-YYYY : ")
            fechaOtorgamiento = datetime.date(int(fechaOtorgamiento.split('-')[1]), int(fechaOtorgamiento.split('-')[0]),1)
            fechaVencimiento = fechaOtorgamiento + datetime.timedelta(days = 730);
            limitePesos = float(input("Ingrese el nuevo límite en pesos de la tarjeta : "))
            if(limitePesos * -1 > 0 ):
                raise Exception("El limite en pesos debe ser positivo")
            limiteDolares = float(input("Ingrese el nuevo límite en dolares de la tarjeta : "))
            if(limiteDolares * -1 > 0 ):
                raise Exception("El limite en dolares debe ser positivo")
            modificar.modificar(TarjetaCredito.TarjetaCredito("", numero, fechaOtorgamiento, fechaVencimiento, limitePesos, limiteDolares))
            print(modificar.mostrar())
        else:
            print("La Tarjeta de Crédito seleccionada no existe")
    
    def bajaTarjetaCredito(self):
        self.mostrarTarjetasDisponibles()
        numero = input("Ingrese el numero de la tarjeta de crédito : ")
        baja = next((t for t in self.get_tarjetas() if (t.get_numero() == numero)), None)
        if (baja != None):
            self.get_tarjetas().remove(baja)
            baja.baja()
        else:
            print("La Tarjeta de Crédito seleccionada no existe")

    def asignarTarjeta(self):
        self.mostrarTitulares()
        tipo = self.opcionesTipoDNI()
        dni = input("Ingrese el dni del Titular : ")
        titular = next((t for t in self.get_titulares() if (t.get_tipo() == tipo and t.get_dni() == dni)), None)
        if(titular != None):
            self.mostrarTarjetasDisponibles()
            numero = input("Ingrese el número de la tarjeta de crédito que desea asignar : ")
            tarjeta = next((t for t in self.get_tarjetas() if (t.get_numero() == numero)), None)
            if(tarjeta != None):
               titular.agregarTarjeta(tarjeta)
               self.get_tarjetas().remove(tarjeta)
               titular.mostrar()
            else:
                print("La Tarjeta de Crédito seleccionada no existe o ya se encuentra asignada")
        else:
            print("El titular seleccionado no existe")

    def quitarTarjeta(self):
        self.mostrarTitulares()
        tipo = self.opcionesTipoDNI()
        dni = input("Ingrese el dni del Titular : ")
        titular = next((t for t in self.get_titulares() if (t.get_tipo() == tipo and t.get_dni() == dni)), None)
        if(titular != None):
            numero = input("Ingrese el número de la tarjeta de crédito que desea asignar : ")
            tarjeta = next((t for t in titular.get_tarjetas() if (t.get_numero() == numero)), None)
            if(tarjeta != None):
                if(tarjeta.get_utilizada() == False):
                    titular.quitarTarjeta(tarjeta)
                    self.get_tarjetas().append(tarjeta)
                    titular.mostrar()
                else:
                    print("No puede quitarle la tarjeta al usuario porque ya fue utilizada al menos 1 vez")
            else:
                print("La Tarjeta de Crédito seleccionada no pertenece al titular seleccionado")
        else:
             print("El titular seleccionado no existe")

    def consumo(self, nombreMoneda):
        self.mostrarTitulares()
        tipo = self.opcionesTipoDNI()
        dni = input("Ingrese el dni del Titular : ")
        titular = next((t for t in self.get_titulares() if (t.get_tipo() == tipo and t.get_dni() == dni)), None)
        if(titular != None):
            numero = input("Ingrese el número de la tarjeta de crédito que desea seleccionar : ")
            tarjeta = next((t for t in titular.get_tarjetas() if (t.get_numero() == numero)), None)
            if(tarjeta != None):
                if(nombreMoneda == "Peso"):
                    valor = float(input("Ingrese el valor del consumo en pesos : "))
                    if( tarjeta.get_saldoPesos() - valor >= tarjeta.get_limitePesos()):
                        tarjeta.set_saldoPesos( tarjeta.get_saldoPesos() - valor)
                        tarjeta.set_utilizada(True)
                        print("Se consumieron $" + str(valor) + " pesos, saldo actual : $" + str(tarjeta.get_saldoPesos()))
                    else:
                        print("El valor del consumo es muy grande, supera el límite en pesos. Límite en pesos : $" + str(tarjeta.get_limitePesos()))
                else:
                    valor = float(input("Ingrese el valor del consumo en dólares : "))
                    if( tarjeta.get_saldoDolares() - valor >= tarjeta.get_limiteDolares()):
                        tarjeta.set_saldoDolares( tarjeta.get_saldoDolares() - valor)
                        tarjeta.set_utilizada(True)
                        print("Se consumieron $" + str(valor) + " dólares, saldo actual : $" + str(tarjeta.get_saldoDolares()))
                    else:
                        print("El valor del consumo es muy grande, supera el límite en dólares. Límite en dólares : $" + str(tarjeta.get_limiteDolares()))
            else:
                print("La Tarjeta de Crédito seleccionada no pertenece al titular seleccionado")
        else:
             print("El titular seleccionado no existe")

    def pago(self, nombreMoneda):
        self.mostrarTitulares()
        tipo = self.opcionesTipoDNI()
        dni = input("Ingrese el dni del Titular : ")
        titular = next((t for t in self.get_titulares() if (t.get_tipo() == tipo and t.get_dni() == dni)), None)
        if(titular != None):
            numero = input("Ingrese el número de la tarjeta de crédito que desea seleccionar : ")
            tarjeta = next((t for t in titular.get_tarjetas() if (t.get_numero() == numero)), None)
            if(tarjeta != None):
                if(nombreMoneda == "Peso"):
                    valor = float(input("Ingrese el valor a pagar en pesos : "))
                    if(tarjeta.get_tipo() == "Platinium"):
                        valor -= (valor * 10 / 100)
                    elif(tarjeta.get_tipo() == "Gold"):
                        valor -= (valor * 20 / 100)
                    else:
                        valor -= (valor * 30 / 100)
                    tarjeta.set_saldoPesos( tarjeta.get_saldoPesos() + valor)
                    tarjeta.set_utilizada(True)
                    print("Se pagaron $" + str(valor) + " pesos, saldo actual : $" + str(tarjeta.get_saldoPesos()))
                else:
                    valor = float(input("Ingrese el valor del consumo en dólares : "))
                    if(tarjeta.get_tipo() == "Platinium"):
                        valor -= (valor * 1 / 100)
                    elif(tarjeta.get_tipo() == "Gold"):
                        valor -= (valor * 2 / 100)
                    else:
                        valor -= (valor * 3 / 100)
                    tarjeta.set_saldoDolares( tarjeta.get_saldoDolares() + valor)
                    tarjeta.set_utilizada(True)
                    print("Se pagaron " + str(valor) + " dólares, saldo actual : $" + str(tarjeta.get_saldoDolares()))
            else:
                print("La Tarjeta de Crédito seleccionada no pertenece al titular seleccionado")
        else:
             print("El titular seleccionado no existe")

    def opcionesTipoDNI(self):
        print("Tipos de DNI : ")
        print("1.   DNI")
        print("2.   Pasaporte")
        ret = input("Seleccione el número correspondiente a la opción elegida : ")
        if(ret == "1"):
            return "DNI"
        elif(ret == "2"):
            return "Pasaporte"
        else:
            raise Exception("El tipo de documento ingresado no es válido")

    def opcionesTipoTarjeta(self):
        print("Tipos de Tarjeta : ")
        print("1.   Platinium")
        print("2.   Gold")
        print("3.   Plata")
        ret = input("Seleccione el número correspondiente a la opción elegida : ")
        if(ret == "1"):
            return "Platinium"
        elif(ret == "2"):
            return "Gold"
        elif(ret == "3"):
            return "Plata"
        else:
            raise Exception("El tipo de tarjeta ingresado no es válido")

    def mostrarTitulares(self):
        if(len(self.get_titulares()) != 0):
            print("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
            print("Titulares disponibles : ")
            for titular in self.get_titulares():
                titular.mostrar()
            print("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
        else:
            print("No hay ningún titular")

    def mostrarTarjetasDisponibles(self):
        if(len(self.get_tarjetas()) != 0):
          print("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
          print("Tarjetas disponibles:")
          for tarjeta in self.get_tarjetas():
                 print(tarjeta.mostrar())
          print("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
        else:
            print("No hay ninguna tarjeta disponible")
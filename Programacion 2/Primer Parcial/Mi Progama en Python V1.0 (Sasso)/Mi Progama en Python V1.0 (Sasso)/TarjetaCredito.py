import datetime
class TarjetaCredito:
    def __init__(self, tipo, numero, fechaOtorgamiento, fechaVencimiento, limitePesos, limiteDolares):
        self.set_tipo(tipo)
        self.set_numero(numero)
        self.set_utilizada(False)
        self.set_fechaOtorgamiento(fechaOtorgamiento)
        self.set_fechaVencimiento(fechaVencimiento)
        self.set_limitePesos(float(limitePesos))
        self.set_limiteDolares(float(limiteDolares))
        self.set_saldoPesos(float(0))
        self.set_saldoDolares(float(0))

    def get_tipo(self):
        return self.__tipo
    def set_tipo(self, value):
        self.__tipo = value

    def get_numero(self):
        return self.__numero
    def set_numero(self, value):
        self.__numero = value

    def get_utilizada(self):
        return self.__utilizada
    def set_utilizada(self, value):
        self.__utilizada = value
    
    def get_fechaOtorgamiento(self):
        return self.__fechaOtorgamiento
    def set_fechaOtorgamiento(self, value):
        self.__fechaOtorgamiento = value

    def get_fechaVencimiento(self):
        return self.__fechaVencimiento
    def set_fechaVencimiento(self, value):
        self.__fechaVencimiento = value
    
    def get_limitePesos(self):
        return self.__limitePesos
    def set_limitePesos(self,value):
        self.__limitePesos = value * -1

    def get_limiteDolares(self):
        return self.__limiteDolares
    def set_limiteDolares(self, value):
        self.__limiteDolares = value * -1

    def get_saldoPesos(self):
        return self.__saldoPesos
    def set_saldoPesos(self, value):
        self.__saldoPesos = value

    def get_saldoDolares(self):
        return self.__saldoDolares
    def set_saldoDolares(self, value):
        self.__saldoDolares = value

    def modificar(self, tarjeta):
        self.set_fechaOtorgamiento(tarjeta.get_fechaOtorgamiento())
        self.set_fechaVencimiento(tarjeta.get_fechaVencimiento())
        self.set_limitePesos(float(self.get_limitePesos()))
        self.set_limiteDolares(float(self.get_limiteDolares()))

    def baja(self):
        del self

    def mostrar(self):
        return 	"Tarjeta: " + self.get_numero() + " 	" + datetime.date.strftime( self.get_fechaOtorgamiento() ,"%m/%Y") + " 	" + datetime.date.strftime(self.get_fechaVencimiento(), "%m/%Y") + "	" + self.get_tipo() + "	 $" + str(self.get_saldoPesos()) + "  U$S" + str(self.get_saldoDolares())
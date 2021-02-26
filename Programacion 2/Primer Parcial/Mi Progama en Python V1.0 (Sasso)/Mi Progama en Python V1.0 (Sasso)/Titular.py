class Titular:
    def __init__(self, tipo, dni, nombre, apellido):
        self.set_tipo(tipo)
        self.set_dni(dni)
        self.set_nombre(nombre)
        self.set_apellido(apellido)
        self.set_tarjetas([])

    def get_tipo(self):
        return self.__tipo
    def set_tipo(self, value):
        self.__tipo = value

    def get_dni(self):
        return self.__dni
    def set_dni(self, value):
        self.__dni = value

    def get_nombre(self):
        return self.__nombre
    def set_nombre(self, value):
        self.__nombre = value

    def get_apellido(self):
        return self.__apellido
    def set_apellido(self, value):
        self.__apellido = value
    
    def get_tarjetas(self):
        return self.__tarjetas
    def set_tarjetas(self, value):
        self.__tarjetas = value

    def modificar(self, titular):
        self.set_nombre(titular.get_nombre())
        self.set_apellido(titular.get_apellido())
        
    def baja(self):
        del self

    def agregarTarjeta(self, tarjeta):
        self.get_tarjetas().append(tarjeta)

    def quitarTarjeta(self, tarjeta):
        self.get_tarjetas().remove(tarjeta)

    def mostrar(self):
        print("Titular: " + self.get_apellido() + ", " + self.get_nombre() +" 	" + self.get_tipo() + " 	" + self.get_dni())
        if(len(self.get_tarjetas()) != 0):
            for tarjeta in self.get_tarjetas():
                print("     " + tarjeta.mostrar())
        else:
            print("     El usuario no posee ninguna tarjeta")
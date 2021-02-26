class Supermercado:
    def __init__(self, cajas ):
        self.cajas = cajas

    def totalMontoPorCobrar(self):
        total = 0
        for caja in self.cajas:
            total += caja.totalMontoPorCobrar()
        return total

    def totalMontoCobrados(self):
        total = 0
        for caja in self.cajas:
            total += caja.totalMontoCobrados()
        return total

    def totalClientesPorCobrar(self):
        count = 0
        for caja in self.cajas:
            count += caja.totalClientesPorCobrar()
        return count
    
    def totalClientesCobrados(self):
        count = 0
        for caja in self.cajas:
            count += caja.totalClientesCobrados()
        return count

    def encolarEnCaja(self, numero, cliente):
        self.cajas[numero].encolar(cliente)
        print("Se agregó a la cola de la caja " + str(numero) + " el cliente : " + cliente.nombre + " con monto a pagar " + str(cliente.monto) + " .")

    def mostrarCajas(self):
        mostrar = "cajas : "
        for caja in self.cajas:
            mostrar = mostrar + str(caja.id) + " "
        mostrar += "."
        print(mostrar)

class Caja:
    def __init__(self, id, cobrar, cobrados):
        self.id = id
        self.porCobrar = cobrar
        self.cobrados = cobrados

    def totalMontoPorCobrar(self):
        if(len(self.porCobrar) != 0):
            total = 0
            for persona in self.porCobrar:
                total += persona.monto
            return total
        else:
            return 0

    def totalMontoCobrados(self):
        if(len(self.cobrados) != 0):
            total = 0
            for persona in self.cobrados:
                total += persona.monto
            return total
        else:
            return 0

    def totalClientesPorCobrar(self):
        return len(self.porCobrar)

    def totalClientesCobrados(self):
        return len(self.cobrados)

    def encolar(self, cliente):
        self.porCobrar.append(cliente)

    def cobrar(self):
        if(len(self.porCobrar) != 0):
            self.cobrados.append(self.porCobrar[0])
            print("Se cobró : $" + str(self.porCobrar[0].monto) + " al cliente " + self.porCobrar[0].nombre)
            self.porCobrar.pop(0)
        else:
            print("No se pudo cobrar porque la caja está vacía")


class Cliente:
    def __init__(self, dni, nombre, monto):
        self.dni = dni
        self.nombre = nombre
        self.monto = monto

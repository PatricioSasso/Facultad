class numerosPrimos():
    def __iter__(self):
        self.numero = 1
        return self

    def __next__(self):
        x = self.a
        self.a += 1
        if(self.es_primo):
            return x
    
    def es_primo(self,num):
        if num < 2:
            for i in range(2, num):
                if num % i == 0:
                    return False
            return True
        else:
            return False

def Main():
    numero = int(input("Ingrese un numero"))
    x = numero;
    for i in range(numero):
        x.__next__
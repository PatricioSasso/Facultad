decision = True
while decision:
    print("Ingrese su capital")
    capital = float(input())
    print("ingrese el interés")
    interes = float(input())
    print("Ingrese el tiempo")
    tiempo = float(input())
    plazoFijo = (capital * interes * tiempo) / (100 * 365)
    txt = "El plazo fijo a pagar es {}"
    print( txt.format(int(plazoFijo)))
    print("¿Desea volver a intentar? . Si = Cualquier tecla | No = N")
    if str(input()).upper() == 'N':
        decision = False
import numpy

tiradas = int(input("Cuántas veces desea tirar un par de dados: "))
arrNumbers = numpy.array([2,3,4,5,6,7,8,9,10,11,12])
arr = numpy.random.choice(arrNumbers,tiradas)
print(arr)
for y in range(len(arrNumbers)):
    count = 0
    for x in range(len(arr)):
        if(arrNumbers[y] == arr[x]):
            count += 1
    print(str(arrNumbers[y]) + " salió " + str(count) + " veces . Porcentaje: %" + str(((count/tiradas)*100)))
        
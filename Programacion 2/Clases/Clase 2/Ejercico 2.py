nArray = [0,0,0]
for i in range(len(nArray)):
    print("ingrese el número " +  str(i + 1))
    nArray[i] = input()
for i in range(1,len(nArray)):
    for j in range(len(nArray) - i):
        if nArray[j+1] < nArray[j]:
            aux = nArray[j]
            nArray[j] = nArray[j+1]
            nArray[j+1] = aux
show = "Números ordenados: "
for i in range(3):
    show = show + nArray[i] + " "
print(show)




productList=[] 
priceList=[]
#consulto si se desea agregar un producto para el while
stop = False
while stop == False:
    print("Choose the name for the product you want to add ")
    addProduct= input()
    print("Choose price for the product ")
    addPrice=input()
    productList.append(addProduct)
    priceList.append(addPrice)
    print("Press ENTER if you don't want to add another product")
    if input() == "":
        stop = True
dictionary = { }
total = 0
stop = False
while stop == False:
    list =[]
    print("Select the facture number")
    key= input()
    print("Select the product")
    product= input()
    print("Select the quantity")
    quantity= int(input())
    if product in productList:
        position= productList.index(product)
        price=int(priceList[position])
        subtotal= quantity * price
        list.append(product)
        list.append(price)
        list.append(quantity)
        list.append(subtotal)
        tupla= tuple(list)
        dictionary[key]=tupla
        total+=subtotal
    else:
        print("The product is not in the list")
    print("Press ENTER if you don't want to add another product")
    if input() == "":
        stop = True
print("Diccionario: ")
for x, y in dictionary.items():
    print(x,y)
print("Total of sold items: ", total)
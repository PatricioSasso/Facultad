list = []
stop = False
while stop == False:
    print("Write the name of the price you want to add")
    add = int(input())
    list.append(add)
    print("Do you want to add a new price to the list? // Yes = Y // No = press any other key")
    selected = input()
    if('Y' != selected.upper()):
        stop = True
list.sort(reverse = True)
print("The highest price of the list is: " + str(list[0]))
print("The lowest price of the list is: " + str(list[len(list)-1]))
avr = 0
for p in list:
    avr += p;
print("The average price of the list is:" + str(avr / len(list)))
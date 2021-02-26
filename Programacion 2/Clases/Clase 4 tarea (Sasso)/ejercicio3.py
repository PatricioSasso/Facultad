information = {}
stop = False
while stop == False:
    print("Write the name field you want the information to add")
    field = str(input())
    print("Write the value of the field you just named")
    value = str(input())
    information.update({field : value})
    print("If you don't want to add new information press ENTER")
    if input() == "":
        stop = True
for i in information:
    print(information[i])
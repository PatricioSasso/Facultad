dictionary = {'euro':'€', 'dollar':'$','yen':'¥'}
print("Select a currency (euro, dollar, yen)")
txt = input().lower();
if txt in dictionary:
    print(dictionary[txt])
else:
    print("That currency does not exist in the dictionary")

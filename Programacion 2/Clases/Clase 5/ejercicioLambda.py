import numpy as np

def addText(txt):
    return lambda add: add + " " + txt

variable = addText("mundo")
print(variable("hola"))
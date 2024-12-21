import os

# Variables de los ejes y fijo un limite
ejeY = 20
ejeX = 30

# variables de un punto (test)
punto = [-5,-5]

# vertices del cuadrado
a = [-4,-8]
b = [0,0]
c = [-8,-4]
d = [0,0]
def dibujarEjes():
    if punto[0] > 0 and punto [1] > 0:  
        for y in range(ejeY):
            print("\033["+str(y)+";0H│", end=" ")
        for x in range(ejeX):
            print("\033["+str(ejeY - 1)+";"+str(x)+"H━", end=" ")
        print("\033[0;0HY", end=" ")
        print("\033["+str(ejeY)+";"+str(ejeX+1)+"HX", end=" ")
        print("\033["+str(ejeY - punto[1] - 1)+";"+str(punto[0] + 1)+"H*("+str(punto[0])+","+str(punto[1])+")", end=" ")
    elif punto[0] < 0 and punto[1] > 0:
        for y in range(ejeY, 0, -1):
            print("\033["+str(y)+";"+str(ejeX)+"H│", end=" ")
        for x in range(ejeX):
            print("\033["+str(ejeY - 1)+";"+str(x)+"H━", end=" ")
        print("\033[0;"+str(ejeX)+"HY", end=" ")
        print("\033["+str(ejeY)+";0H-X", end=" ")
        print("\033["+str(ejeY - punto[1] - 1)+";"+str(ejeX + punto[0])+"H*("+str(punto[0])+","+str(punto[1])+")", end=" ")
    elif punto[1] < 0 and punto[0] > 0:
        for y in range(ejeY):
            print("\033["+str(y)+";0H│", end=" ")
        for x in range(ejeX):
            print("\033[0;"+str(x)+"H━", end=" ")
        print("\033["+str(ejeY)+";0H-Y", end=" ")
        print("\033[0;"+str(x)+"HX", end=" ")
        print("\033["+str(-punto[1] + 1)+";"+str(0 + punto[0])+"H*("+str(punto[0])+","+str(punto[1])+")", end=" ")
    elif punto[0] < 0 and punto[1] < 0:
        for y in range(ejeY, 0, -1):
            print("\033["+str(y)+";"+str(ejeX)+"H│", end=" ")
        for x in range(ejeX):
            print("\033[0;"+str(x)+"H━", end=" ")
        print("\033["+str(ejeY)+";"+str(ejeX)+"H-Y", end=" ")
        print("\033[0;0H-X", end=" ")
        print("\033["+str(-punto[1] + 1)+";"+str(ejeX + punto[0])+"H*("+str(punto[0])+","+str(punto[1])+")", end=" ")
    dibujarCuadrado()

def dibujarCuadrado():
    b[0] = c[0]
    b[1] = a[1]
    d[0] = a[0]
    d[1] = c[1]
    if a[0] < 0 and a[1] < 0 and c[0] < 0 and c[1] < 0:
        ejeY = 0
        ejeX = 0

    for linX in range(b[0] - a[0]):
        print("\033["+str(ejeY + a[1] + 1)+";"+str(linX + a[0] + 1)+"H━", end="")
        print("\033["+str(ejeY + d[1] + 1)+";"+str(linX + d[0] + 1)+"H━", end="")
    for linY in range(a[1] - d[1]):
        print("\033["+str(ejeY + a[1] + linY)+";"+str(ejeX + 1)+"H|", end="")
        print("\033["+str(ejeY + b[1] + linY)+";"+str(ejeX + 1)+"H|", end="")
    # Dibujo los  vertices del cuadrado
    print("\033["+str(ejeY - a[1] - 1)+";"+str(a[0] + 1)+"H*", end="")
    print("\033["+str(ejeY - b[1] - 1)+";"+str(b[0] + 1)+"H*", end="")
    print("\033["+str(ejeY - c[1] - 1)+";"+str(c[0] + 1)+"H*", end="")
    print("\033["+str(ejeY - d[1] - 1)+";"+str(d[0] + 1)+"H*", end="")

# Manejo de una archivo con logs anteriores


def main():
    os.system("cls")
    dibujarEjes()
    input()


if __name__ == '__main__':
    main()
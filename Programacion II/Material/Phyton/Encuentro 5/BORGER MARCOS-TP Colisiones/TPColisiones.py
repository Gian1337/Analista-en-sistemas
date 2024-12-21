import os
import datetime
from colorama import Fore
#TODO Variables globales

# Intancio cada vertice del cuadraro vertice = (x,y)
a = [0,0]
b = [0,0]
c = [0,0]
d = [0,0]

# Variables de los ejes y fijo un limite
ejeY = 20
ejeX = 30

# Coordenadas del punto
punto = [0,0]

def main():
    os.system("cls")
    solicitarDatosCuadrado()
    solicitarPunto()
    dibujarEjes()
    dibujarCuadrado()
    print(Fore.RED +"\033["+str(ejeY - punto[1] - 1)+";"+str(punto[0] + 1)+"H*("+str(punto[0])+","+str(punto[1])+")", end=" ")
    input()
    if detectarColision() == True:
        print(Fore.RED + "El punto colisiona con el cuadrado")
        guardarResultado(f'El cuadrado con vertice en A({a[0]}x,{a[1]}y) y C({c[0]}x,{c[1]}y) colisiono con el PUNTO ({punto[0]}x,{punto[1]}y)')
        detectarColisionLinea()
    else:
        print(Fore.GREEN + "No hay colision con el cuadrado")
        guardarResultado(f'El cuadrado con vertice en A({a[0]}x,{a[1]}y) y C({c[0]}x,{c[1]}y) NO colisiono con el PUNTO ({punto[0]}x,{punto[1]}y)') 
    input(Fore.RESET + "Presione Enter para finalizar...")

def dibujarEjes():
    for y in range(ejeY):
        print("\033["+str(y)+";0H│", end=" ")
    for x in range(ejeX):
        print("\033["+str(ejeY - 1)+";"+str(x)+"H━", end=" ")
    print("\033[0;0HY", end=" ")
    print("\033["+str(ejeY)+";"+str(ejeX+1)+"HX", end=" ")

def dibujarCuadrado():
    # Dibujo las lineas del cuadrado
    for linX in range(b[0] - a[0]):
        print(Fore.GREEN + "\033["+str(ejeY - a[1] - 1)+";"+str(linX + a[0] + 1)+"H━", end="")
        print(Fore.GREEN +"\033["+str(ejeY - d[1] - 1)+";"+str(linX + d[0] + 1)+"H━", end="")
    
    for linY in range(a[1] - d[1]):
        print(Fore.GREEN +"\033["+str(ejeY - a[1] + linY)+";"+str(a[0] + 1)+"H|", end="")
        print(Fore.GREEN +"\033["+str(ejeY - b[1] + linY)+";"+str(b[0] + 1)+"H|", end="")
    
    # Dibujo los  vertices del cuadrado
    print(Fore.GREEN +"\033["+str(ejeY - a[1] - 1)+";"+str(a[0] + 1)+"H*", end="")
    print(Fore.GREEN +"\033["+str(ejeY - b[1] - 1)+";"+str(b[0] + 1)+"H*", end="")
    print(Fore.GREEN +"\033["+str(ejeY - c[1] - 1)+";"+str(c[0] + 1)+"H*", end="")
    print(Fore.GREEN +"\033["+str(ejeY - d[1] - 1)+";"+str(d[0] + 1)+"H*", end="")

def solicitarDatosCuadrado():
    try:
        print("Ingrese las coordenadas del vertice A del cuadrado:")
        a[0] = int(input("Ingrese X del vertice A: "))
        a[1] = int(input("Ingrese Y del vertice A: "))

        largo = int(input("Ingrese el largo de cada lado del cuadrado: "))
        
        c[0] = a[0] + largo
        c[1] = a[1] - largo
        
        # Tomando en cuenta que es un cuadrado ya sabemos que coordenadas tendran los demás vertices
        b[0] = c[0]
        b[1] = a[1]

        d[0] = a[0]
        d[1] = c[1]
        
        if (a[0] > ejeX or a[0] < 0) or (a[1] > ejeY or a[1] < 0) :
            print("El punto ingresado esta fuera de los limites")
            input()
            exit()        
        os.system("cls")
    except(ValueError): 
        print("Debe ingresar un valor correcto")
        input()
        os.system("cls")
        solicitarDatosCuadrado()
        

def detectarColision():
    os.system("cls")
    if punto[0] >= a[0] and punto[0] <= b[0]:
        if punto[1] <= a[1] and punto[1] >= d[1]:
            return True
        else:
            return False
    else:
        return False


def solicitarPunto():
    try:
        print("Ingrese las coordenadas del punto a evaluar:")
        punto[0] = int(input("Ingrese el eje X del punto: "))
        punto[1] = int(input("Ingrese el eje Y del punto: "))
        if (punto[0] > ejeX or punto[0] < 0) or (punto[1] > ejeY or punto[1] < 0) :
            print("El punto ingresado esta fuera de los limites")
            input()
            exit()
        os.system("cls") 
    except(ValueError):
        print("Debe ingresar un valor numerico")
        input()
        os.system("cls")
        solicitarPunto()

def detectarColisionLinea():
    if (punto[1] == a[1]) and (punto[0] > a[0] and punto[0] < b[0]):
        print("Hay colision en la linea A - B")
    elif (punto[0] == a[0]) and (punto[1] < a[1] and punto[1] > d[1]):
        print("Hay colision en la linea A - D")
    elif (punto[1] == d[1]) and (punto[0] > d[0] and punto[0] < c[0]):
        print("Hay colision en la linea D - C")
    elif (punto[0] == b[0]) and (punto[1] < b[1] and punto[1] > c[1]):
        print("Hay colision en la linea B - C")

def guardarResultado(resultado):
    archivo = open('resultados.txt', 'a+')
    fecha = datetime.datetime.utcnow().date()
    archivo.write('---------------------------------------------\n')
    archivo.write(f'[{fecha}] : {resultado}\n')
    archivo.write('---------------------------------------------\n')
    archivo.close()  

if __name__ == "__main__":
    main()


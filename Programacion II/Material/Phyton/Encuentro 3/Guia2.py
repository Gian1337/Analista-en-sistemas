import os
# 1- Crear dos variables enteras y mostrar la suma de ambas en pantalla
os.system("cls")
num1 = 4
num2 = 20

print(4+20)
input("Presione enter para continuar..")

# 2- Dada una variable entera, sumarle 1 en una línea diferente y mostrar el resultado en pantalla.
os.system("cls")
var1 = int(input("Ingrese un valor numerico: "))
var1 += 1

print(var1)
input("Presione enter para continuar..")

# 3- Ingresar una cadena por teclado, para luego mostrarla en pantalla
os.system("cls")
cadena = input("Ingresa un texto: ")

print(f"El texto ingresado fue: {cadena}")
input("Presione enter para continuar..")
# 4- Dado un valor que se ingresa por teclado, mostrar el 25% de ese valor en pantalla
os.system("cls")
valor = int(input("Ingresa un numero: "))

print(f"El 25% del valor ingresado es {valor * 25 / 100}")
input("Presione enter para continuar..")

'''5- Ingresar por teclado un valor entero, para asignarlo a una variable llamada temperatura. Luego ingresar una cadena para
asignarla a una variable llamada localidad. mostrar en pantalla la leyenda en la zona .... Tenemos una temperatura de ..... (usar
los comodines %) '''
os.system("cls")
valTemperatura = int(input("Ingrese la temperatura actual: "))
nomLocalidad = str(input("Ingrese el nombre de su localidad: "))

print("En la localidad %s hay una temperatura de %d grados" % (nomLocalidad, valTemperatura))
input("Presione enter para continuar..")

# 6- Dados los lados de un cuadrado, mostrar en pantalla el valor de su superficie
os.system("cls")
lado = float(input("Ingrese el tamaño de un lado del cuadrado: "))
print(f"La superficie del cuadrado es de {lado + lado}")
input("Presione enter para continuar..")

# 7- Copiar y ejecutar el siguiente código, justifique la salida que se obtiene por pantalla
os.system("cls")
numero1,numero2=0,0
numero1=int(input("Ingresar un numero : "))
numero2=int(input("Ingresar un numero : "))
if numero1 > numero2:
    print(f"{numero1} es mayor a {numero2}")
else:
    if numero2 > numero1:
        print(f"{numero2} es mayor a {numero1}")
    else:
        print(f"{numero2} es igual a {numero1}")

input("Presione enter para continuar..")

# RESPUESTA: Se obtiene por pantalla la comparación de ambas variables acorde a lo ingresado

'''8- Implementar un algoritmo en Python que, dados dos valores de las acciones de la empresa Techint del día 23-8-2022 y otra del
día 22-8-2022 permita informar si las acciones están el alza.'''
os.system("cls")

accion1 = float(input("Ingrese el valor de las acciones de la fecha (22-8-2022): "))
accion2 = float(input("Ingrese el valor de las acciones de la fecha (23-8-2022): "))
if accion2 > accion1 :
    print("Las acciones estan en alza")
elif accion2 < accion1 :
    print("Las acciones bajaron")
elif accion2 == accion1 :
    print("Las acciones siguen igual")

input("Presione enter para continuar..")
 
'''9- Tomando el mismo caso del ejercicio anterior, cambiar el código para ingresar por teclado el valor de dos acciones de días
distintos. Tomando dicha información informar si conviene comprar, vender o no reacciona.'''

os.system("cls")
fecha1 = str(input("Ingrese la fecha de la acción: "))
accion1 = float(input(f"Ingrese el valor de las acciones de la fecha ({fecha1}): "))

fecha2 = str(input("Ingrese la fecha de la accion: "))
accion2 = float(input(f"Ingrese el valor de las acciones de la fecha ({fecha2}): "))

if accion2 > accion1 :
    print("No conviene comprar acciones")
elif accion2 < accion1 :
    print("Conviene comprar acciones")
input("Presione enter para continuar..")

'''10- Nos contratan para hacer una segmentación de mercados, el equipo decido usar Python para implementar una solución. El
relevamiento del problema describe que al tener el dato de la edad de una persona debe informar si se encuentra entre los 18 y
los 36 años.'''
os.system("cls")
nomPersona = str(input("Ingrese el nombre de la persona: "))
edadPersona = int(input(f"Ingrese la edad de {nomPersona}: "))

if edadPersona >= 18 and edadPersona <= 36 :
    print(f"{nomPersona} se encuentra en el rango de edad")
else :
    print(f"{nomPersona} no se encuentra en el rango de edad")

input("Presione enter para continuar..")

'''11- Un estudio contable, necesita automatizar un proceso de gran importancia. Se debe discriminar los cheques que tiene tienen un
importe superior a los 100.000 pesos. Para ello, debemos realizar un programa que me permita ingresar el importe del cheque.
Al terminar la carga, el sistema debe informar si el importe es mayor a 100.000'''

os.system("cls")

importe = float(input("Ingrese el importe del cheque: "))

if importe > 100000 :
    print("El importe del cheque es mayor a 100.000")

input("Presione enter para continuar..")

# 12- Crear un programa que dado un valor entero que se ingresa por teclado, informe si el 40% del valor ingresado se encuentra dentro del rango de 10 y 42.
os.system("cls")
valor = int(input("Ingrese un valor numerico: "))
porcentaje = valor * 40 / 100

if porcentaje >= 10 and porcentaje <= 42 :
    print("El valor ingresado esta dentro del rango (10 - 42)")
else :
    print("El valor ingresado esta fuera del rango")

input("Presione enter para continuar..")
 

# 13 
os.system("cls")
pbi2020 = 21 * 20 + 10 * 10
pbi2021 = 20 * 22 + 9 * 12
pbi2022 = 22 * 21 + 10 * 11

print(f"El PBI de cada año es: (2020)-> {pbi2020} (2021)-> {pbi2021} (2022)-> {pbi2022}")

if pbi2020 > pbi2021 and pbi2020 > pbi2022 :
    print("El PBI del año 2020 es el mayor")
elif pbi2021 > pbi2020 and pbi2021 > pbi2022 :
    print("El PBI del año 2021 es el mayor")
elif pbi2022 > pbi2020 and pbi2022 > pbi2021 :
    print("El PBI del año 2022 es el mayor")
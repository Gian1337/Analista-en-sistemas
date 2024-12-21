#OPERADORES RELACIONALES
a = 5
b = 6

#1- Si tenemos dos variables llamadas a y b, donde a=5 y b=6. Que resultado arroja un:
print (a==b) 
#Respuesta: False


#2- Si tenemos dos variables llamadas a y b, donde a=5 y b=6. Que resultado arroja un
print ("a==b") 
#Respuesta: a==b

#3- ¿Cuál es el error en el código de abajo?
###### print(a=b)
'''
Respuesta: no se esta evaluando una condicion, variable u operacion para imprimir, sino que se esta evaluando 
una asignacion y no es posible hacer un print de la misma. 
TypeError: 'a' is an invalid keyword argument for print()
'''

#4- ¿Qué arroja el siguiente código?
a=7
print(a>=7)
#Respuesta: True

#OPERADORES ARITMETICOS
#5- ¿Qué valor muestra en pantalla el siguiente código?
print(5 + 7)
#Respuesta: 12

#6- ¿Qué valor muestra en pantalla el siguiente código?
print(2 + 4 * 2)
#Respuesta: 10

#7- ¿Qué valor muestra en pantalla el siguiente código?
print((2 + 4) * 2)
#Respuesta: 12

#8- ¿Qué valor muestra en pantalla el siguiente código?
print( 3 % 2)
#Respuesta: 1

#9- ¿Qué valor muestra en pantalla el siguiente código?
print( 3 / 2)
#Respuesta: 1.5

#10- ¿Qué valor muestra en pantalla el siguiente código?
print( 3 // 2)
#Respuesta: 1

#OPERADORES LOGICOS
#11- ¿Por qué el siguiente código devuelve 2?
print( 3 and 2)
#Respuesta: Porque se estan evaluando bit a bit los valores 3 y 2 

#12- ¿Qué agregar al siguiente código para que muestre el resultado en binario)
###### print( ___(3) and ___(2))
#Respuesta: hay que llamar a la funcion bin() en ambos casos

#13- ¿Cómo guardar en la variable a y v, el valor 3 en binario y el valor 2 en binario sin usar bin, y que el print me devuelva 2?
###### a,b=____,____
print (a and b)
#Respueta: a,b=0b11,0b10

#14- ¿Cuál es el resultado?
a=True
print (not a)
#Respuesta: False

#15- ¿Cuál es el resultado?
a=6
print (a)
#Respuesta: 6

#16- ¿Cuál es el resultado?
a=6
print (not a)
#Respuesta: False

#17- ¿Cuál es el resultado?
a=0
print (not a)
#Respuesta: True

#18- ¿Cuál es el valor booleando que se obtiene?
a=0
print (bool(0))
#Respuesta: False

#ENTRADAS Y SALIDAS
#19- ¿Qué le falta al siguiente código para ingresar un dato por teclado?
###### a=_____()
#Respuesta: input

#20- ¿Qué le falta al siguiente código para qué funcione?
a=int(input("Ingrese un valor : "))
print( "El valor ingresado es {a}")
#Respuesta: falta f antes de la cadena a mostrar ej: print( f"El valor ingresado es {a}")

#21- ¿Qué le falta al código para que muestre la frase “Hola Mundo”?
###### print("Hola",_______)
print("Mundo")
#Respuesta: le falta el string "Mundo" como segundo parametro

#22- El código print("el @ y la " son caractreres") arroja el siguiente error. ¿Qué debe agregar para solucionarlo?
'''
print("el @ y la " son caractreres")
 ^
SyntaxError: unterminated string literal (detected at line 1)
'''
'''
Respuesta: hay que agregar el caracter de escape \ antes de la comilla doble que esta dentro de la cadena principal
ej: print("el @ y la \" son caractreres")
'''

#LIBRERIAS os y Math

#23- ¿Cómo importar la librería math?
#Respuesta: import math

#24- ¿Cómo importar de la librería math solo degrees, radians y pi?
#Respuesta: from math import degrees,radians,pi

#25- ¿Qué le falta al siguiente código para resolver los errores?
import os
######__.system( cls )
#Respuesta: falta la llamada a la libreria. Ej: os.system( cls )

#INSTRUCCIONES DE DECISION

#26- Tomando las líneas con los print ¿Qué número de línea ejecuta este código?
a=5
if a == 5:
    print("Es igual a 5")
print("Seguir pensando")
#Respuesta: Ejecuta las lineas: 3 - print("Es igual a 5") y 4 - print("Seguir pensando")

#27- Tomando las líneas con los print ¿Qué número de línea ejecuta este código?
a=6
if a == 5:
    print("Es igual a 5")
else:
    print("No es igual a 5")
print("Seguir pensando")
#Respuesta: Ejecuta las lineas: 5 - print("No es igual a 5") y 6 - print("Seguir pensando")

#28- Tomando las líneas con los print ¿Qué número de línea ejecuta este código?
a=4
if a == 5:
    print("Es igual a 5")
elif a>5:
    print("No es igual a 5")
print("Seguir pensando")
#Respuesta: Ejecuta la linea 6 - print("Seguir pensando")

#29- Tomando las líneas con los print ¿Qué número de línea ejecuta este código?
a=8
if a == 5:
    print("Es igual a 5")
else:
    if a>5:
        print("No es igual a 5")
    else:
        print("No tengo idea")
        print("Seguir pensando")
#Respuesta: Ejecuta la linea 6 - print("No es igual a 5")

# 30- Crear dos variables enteras y mostrar la suma de ambas en pantalla
ent1 = 5
ent2 = 20
print(ent1 + ent2)

# 31- Dada una variable entera, sumarle 1 en una línea diferente y mostrar el resultado en pantalla.
var1 = 11
var1 = var1 + 1
print(var1) 

# 32- Ingresar una cadena por teclado, para luego mostrarla en pantalla
cadena = input("Ingrese un texto: ")
print(cadena)

# 33- Dado un valor que se ingresa por teclado, mostrar el 25% de ese valor en pantalla
numero = int(input("Ingrese un numero: "))
print("El 25% del valor ingresado es:", numero * 25 / 100)

# 34 ---
'''
34- Ingresar por teclado un valor entero, para asignarlo a una variable llamada temperatura. Luego ingresar una cadena para
asignarla a una variable llamada localidad. mostrar en pantalla la leyenda en la zona .... Tenemos una temperatura de .....
(usar los comodines %)
'''
temperatura = int(input("Ingrese la temperatura actual: "))
localidad = input("Ingrese el nombre de la localidad: ")

print("En la zona de %s tenemos una temperatura de %d grados." % (localidad,temperatura))

# 35- Dados los lados de un cuadrado, mostrar en pantalla el valor de su superficie
lado = int(input("Ingrese el tamaño de un lado del cuadrado: "))
print("La superficie del cuadrado es de", lado * lado)

# 36- Dados los lados de un rectángulo, mostrar en pantalla el valor de su superficie
lado1 = int(input("Ingrese el ancho del rectangulo: "))
lado2 = int(input("Ingrese el alto del rectangulo: "))
print("La superficie del rectangulo es de", lado1 * lado2)

#37- Dado un número real con 7 decimales, mostrar el mismo valor con un print recortado solo en los primeros 3 decimales.
numero_real = float(input("Ingrese un numero real con más de 3 decimales: "))
print("{:.3f}".format(numero_real))

# 38- Tomando el grafico como referencia, si tenemos el punto A(0,4) y el punto B(6,0) calcular la distancia entre el punto A y el punto B
import math
a,b = 4,6
sum_cuadrados = a**2 + b**2
print("Entre el punto A y B hay una distancia de {0:.2f}".format(math.sqrt(sum_cuadrados)))

# 39
altura = 10
triangulo_izq_ang = 60
triangulo_der_ang = 45

distancia_A = altura / math.sin(math.radians(triangulo_izq_ang))
distancia_B = altura / math.sin(math.radians(triangulo_der_ang))

print("La distancia al punto A es: {0:.2f}".format(distancia_A))
print("La distancia al punto B es: {0:.2f}".format(distancia_B))

# 40- Al ejecutar print(((True and False) or (not true)) and true) ¿ Qué obtenemos a la salida?

print(((True and False) or (not True) and True))

# Respuesta: False -> Dicha comparación en ambos casos (true and false) devuelve false
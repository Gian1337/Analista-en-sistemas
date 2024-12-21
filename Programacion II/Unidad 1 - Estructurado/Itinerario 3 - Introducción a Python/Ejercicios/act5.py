'''
Alumno: Gianluca Carlini
Actividad: 05
Fecha Límite: 01/05/2024
'''

#IF - Básico

#Ejercicio 1
'''
var = int(input("Ingrese un valor: "))

if(var % 2 == 0):
    print("Es Par")
else:
    print("Es Impar")
'''

#Ejercicio 2
'''
nro1 = int(input("Ingrese el primer valor: "))
nro2 = int(input("Ingrese el segundo valor: "))

if(nro1>nro2):
    print(f"El primer valor: {nro1} es mayor al segundo valor: {nro2}")
else:
    print("El segundo valor es mayor al primero")
'''


#Ejercicio 3

'''
edad = int(input("Ingrese su edad:"))

if edad >= 18:
    print("Mayor de edad")
else:
    print("Menor de edad")
'''

#Ejercicio 4
'''
texto = input("Ingrese la cadena de texto: ")
longitud = len(texto) #Conteo de caracteres

if longitud <= 10:
    print("La cadena es menor a 10")
else:
    print("La cadena es mayor a 10")
'''

#Ejercicio 5
'''
numero = int(input("Ingrese un numero aleatorio:"))

if numero > 0:
    print("El numero es mayor a 0")
else:
    print("El numero es igual a 0 o menor")
'''

#Ejercicio 6
'''
genero = input("Ingrese su género: ")

if  genero.lower() == "hombre":
    print("Es hombre")
else:
    print("Es mujer")
'''

#Ejercicio 7
'''
numero = int(input("Ingrese un numero: "))

if numero  % 3 == 0:
    print("El número es divisible por 3")
else:
    print("El número no es divisible por 3")
'''

#Ejercicio 8
'''
contraseña = input("Ingrese su contraseña: ")

if contraseña == "12345":
    print("Su contraseña es correcta")
else:
    print("Contraseña incorrecta")
'''

#Ejercicio 9
'''
numero = int(input("Ingrese un número: "))

if numero % 4 == 0 and numero % 2 == 0:
    print("El numero es par y divisible por 4")
else:
    print("El numero no es par y divisible por 4")
'''

#Ejercicio 10
'''
dia = int(input("Ingrese su día de nacimiento (1-31): "))
mes = int(input("Ingrese su mes de nacimiento (1-12): "))


if (mes == 3 and 21 <= dia <= 31) or (mes == 4 and 1 <= dia <= 20):
    print("Signo Aries")
else:
    print("Otro signo")
'''

#If nivel Medio

#Ejercicio 11
'''
letra = input("Ingrese una  letra del alfabeto: ")

if letra.lower() == 'a' or 'e' or 'i' or 'o' or 'u':
    print("Es una vocal")
else:
    print("No es una vocal")
'''

#Ejercicio 12
'''
edad = int(input("Ingrese su edad: "))
altura = int(input("Ingrese su altura (cm): "))

if edad >= 18 and altura > 180:
    print("Mayor de edad y alto")
else:
    print("No cumple las condiciones")
'''

#Ejercicio 13

'''
numero = int(input("Ingrese un numero: "))

es_primo = True

if numero <= 1:
    es_primo = False
else:
    for i in range(2, int(numero ** 0.5) + 1):
        if numero % i == 0:
            es_primo = False
            break

if es_primo:
    print("Es un número primo.")
else:
    print("No es un número primo.")
'''

#Ejercicio 14

'''
calificacion = int(input("Ingrese un número del 0 al 10: "))

if calificacion >= 6:
    print("Aprobaste")
else:
    print("Reprobaste")
'''

#Ejercicio 15
'''
edad = int(input("Ingrese su edad: "))
genero = input("Ingrese su género: ")
estado_civil = input("Ingrese su estado civil: ")

if edad >= 30 and genero.lower() == "hombre" and estado_civil.lower() == "casado":
    print("Hombre casado mayor a 30 años")
else:
    print("No cumple las condiciones")
'''

#Ejercicio 16
'''
def busca_mayor():
    
    nro1 = int(input("Ingrese el primer número entero: "))
    nro2 = int(input("Ingrese el segundo numero: "))
    nro3 = int(input("Ingrese el tercer numero: "))

    nro_mayor= max(nro1, nro2,nro3)

    print(f"El numero mayor es {nro_mayor}")

busca_mayor()
'''

#Ejercicio 17
'''
peso = int(input("Ingrese su peso: "))
altura = int(input("Ingrese su altura(cm): "))
imc = peso / (altura ** 2)

if imc >= 18.5 and imc <= 24.9:
    print("Tiene un peso saludable")
else:
    print("No tiene un peso saludable")
'''

#Ejercicio 18
'''
def calcular_suma(numero):
    suma = 0
    for i in range(1, numero):
        if numero % i == 0:
            suma += i
    return suma

def verificar_nro_perfecto():
    numero = int(input("Ingrese un número entero: "))
    
    suma_divisores = calcular_suma(numero)
    
    if suma_divisores == numero:
        print("Es un número perfecto.")
    else:
        print("No es un número perfecto.")


verificar_nro_perfecto()
'''

#Ejercicio 19
'''
edad = int(input("Ingrese su edad: "))

if edad >= 13 and edad <= 17:
     print("Adolescente")
elif edad >= 18 and edad <= 29:
    print("Adulto joven")
else:
    print("No estás en ninguna categoría")
'''

#Ejercicio 20
'''
dia = int(input("Ingrese su día de nacimiento (1-31): "))
mes = int(input("Ingrese su mes de nacimiento (1-12): "))


if (mes == 4 and 21 <= dia <= 31) or (mes == 5 and 1 <= dia <= 21):
    print("Signo Tauro")
elif (mes == 5 and 22 <= dia <= 31) or (mes == 6 and 1 <= dia <= 21):
    print("Signo Géminis")
else:
    print("Ninguno de esos signos")
'''
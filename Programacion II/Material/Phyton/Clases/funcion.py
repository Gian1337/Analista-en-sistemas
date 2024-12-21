'''
# METODOS PARA DECLARAR FUNCIONES

# Funcion sin parametros ni retorno
def saludo():
    print("Hola saludos!")

# Funcion con parametro pero sin retorno
def saludo(nombre):
    print(f"Hola {nombre} saludos!")

# Funcion con parametros y con retorno
def suma(a,b):
    return a + b
'''
import os

#Ejemplo curioso de como Python retorna tuplas en sus funciones
def suma(a,b):
    suma = a + b
    return a,b,suma

# a,b = 0,0 --> es una tupla (no retorna más valores solo es una colección)
a,b,mensaje = suma(2,3)
print(f"La suma entre en numero {a} + {b} es {mensaje}")
input()
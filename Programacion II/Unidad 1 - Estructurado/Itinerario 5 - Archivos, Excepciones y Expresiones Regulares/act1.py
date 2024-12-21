'''
Alumno: Gianluca Carlini
Actividad: Guía de Ejercicios N° 6
Fecha: 22/05/2024
Tema: Funciones
'''

#Ejercicio 1
'''
alto = int(input("Ingrese el alto: "))
ancho = int(input("Ingrese el ancho: "))

def getDibujo():
    for i in range(alto):
        for j in range(ancho):
            print("+",end="")
        print()

getDibujo()
'''

#Ejercicio 3
'''
altura = int(input("Ingrese la altura: "))
anchura = int(input("Ingrese la anchura: "))
caracter = input("Ingrese el caracter: ")

for i in range(altura):
    for j in range(anchura):
        print(caracter, end="")
    print()
'''

#Ejercicio 6
'''

anchura = int(input("Ingrese la anchura: "))

def dibujo_tlo(anchura):
    for i in range(1, anchura + 1):
        linea = "*" * i
        print(linea)

def dibujos_tlo(anchura):
    for anchura in range(1, anchura + 1):
        dibujo_tlo(anchura)
        print()

dibujos_tlo(anchura)
'''
        

#Ejercicio 7
'''
print("COMPROBADOR DE AÑOS BISIESTOS")

def compruebaAño(fecha):
    if fecha % 400 == 0 or (fecha % 100 != 0 and fecha % 4 == 0):
        print("El año", fecha, "es BISIESTO")
    else:
        print("El año", fecha, "NO es BISIESTO")
        

compruebaAño(fecha = int(input("Ingrese un año: ")))
'''

#Ejercicio 8
'''
print("CONTADOR DE AÑOS BISIESTOS")

fecha = int(input("Ingrese la primer fecha: "))
fecha2 = int(input(f"Ingrese la segunda fecha posterior a {fecha}: "))

def compruebaAño(año):
    if año % 400 == 0 or (año % 100 != 0 and año % 4 == 0):
        return True
    else:
        return False

def contadorAño(fecha, fecha2):
    if(fecha2 < fecha):
        print(f"{fecha2} no es mayor que {fecha}")
    else:
        print("OK")
    
    contador = 0
    
    for pFecha in (fecha, fecha2 + 1):
        if compruebaAño(pFecha):
            contador += 1
            
    return contador

# cantidad años bisiestos
print(contadorAño(fecha,fecha2))
'''

#Ejercicio 9
'''
def creaLista():
    numero = int(input("Digame cuantas palabras tiene la lista: "))
    
    if numero < 1:
        print("Error")
    else:
        lista = []
        for i in range (numero):
            print("Escriba la palabra: ", str(i + 1) + ":", end=" ")
            palabra = input()
            lista += [palabra]
        print(lista)

creaLista()
'''

#Ejercicio 11
'''
print("Generador de Listas")

cantidadListas = int(input("Ingrese la cantidad de listas que quiere crear"))

def creaListas(nroListas):
    listasCreadas = []
    
    for i in range(1, nroListas + 1):
        elementos = int(input("Ingrese la cantidad de elementos: "))
        listas = []
        
        for j in range(elementos):
            elemento = input(f"Ingrese elemento {j+1} para lista {i}: ")
            listas.append(elemento)
    
        listasCreadas.append(listas)
        
    return listasCreadas

listas= creaListas(cantidadListas)

for i, lista in enumerate(listas):
    print(f"Lista {i + 1}: {lista}")
    '''
    

#Ejercicio 12
'''
cantidadListas = 2

def creaListas(cantidadListas):
    listasCreadas = []
    
    for i in range(1, cantidadListas + 1):
        elementos = int(input("Ingrese la cantidad de elementos: "))
        listas = []
        
        for j in range(elementos):
            elemento = input(f"Ingrese elemento {j+1} para lista {i}: ")
            listas.append(elemento)
    
        listasCreadas.append(listas)
        
    return listasCreadas

def eliminaElemento(listas):
    elementos = int(input("Cuantos elementos quiere eliminar: "))
    eliminar = []
    
    for i in range (elementos):
        elemento = input("Escriba la palabra a eliminar: ")
        eliminar.append(elemento)
        
    print(f"Lista de palabras a eliminar: {eliminar}")
    
    for i in range(len(listas)):
        lista = listas[i]
        listas[i] = [elemento for elemento in lista if elemento not in eliminar]
    
    print("Nueva Lista: ")
    for i, lista in enumerate(listas,1):
        print(f"Lista{i}: {lista}")
    
listasCreadas = creaListas(cantidadListas)
eliminaElemento(listasCreadas)

print(listasCreadas)
'''
#Ejercicio 1

def dibujar_rectangulo(ancho, alto):
    for i in range(alto):
        for j in range(ancho):
            print("*", end="")
        print()

def main():
    ancho = int(input("Introduzca la anchura del rectángulo: "))
    alto = int(input("Introduzca la altura del rectángulo: "))
    dibujar_rectangulo(ancho, alto)

#Ejercicio 3

def dibujar_rectangulo_figura(ancho, alto, caracter):
    for i in range(alto):
        for j in range(ancho):
            print(caracter, end="")
        print()

def main3():
    ancho = int(input("Introduzca la anchura del rectángulo: "))
    alto = int(input("Introduzca la altura del rectángulo: "))
    caracter = input("Introduzca el caracter a utilizar: ")
    dibujar_rectangulo_figura(ancho, alto, caracter)

#Ejercicio 4

def dibujar_mitad_superior(ancho):
    for i in range(1, ancho + 1):
        print("*" * i)

def dibujar_mitad_inferior(ancho):
    for i in range(ancho - 1, 0, -1):
        print("*" * i)

def main4():
    ancho = int(input("Introduzca la anchura del triángulo: "))
    dibujar_mitad_superior(ancho)
    dibujar_mitad_inferior(ancho)

#Ejercicio 7

def es_bisiesto(año):
    if año % 4 == 0 and (año % 100 != 0 or año % 400 == 0):
        return True
    else:
        return False

def main5():
    año = int(input("Introduzca un año: "))
    if es_bisiesto(año):
        print("El año", año, "es bisiesto.")
    else:
        print("El año", año, "no es bisiesto.")

#Ejercicio 8

def main6():
    print("CONTADOR DE AÑOS BISIESTOS")
    año = int(input("Introduzca el primer año: "))
    año2 = int(input(f"Introduzca el segundo año, debe ser posterior a {año}: "))

    while año2 <= año:
        print(f"El año {año2} no es mayor que el año {año}. Intentelo de nuevo.")
        año2 = int(input(f"Introduzca el segundo año, debe ser posterior a {año}: "))

    cant_bisiestos = 0
    cant_rango_años = año2 - año + 1
    for i in range(año, año2):
        if es_bisiesto(i):
            cant_bisiestos += 1 
    
    print(f"De {año} a {año2} hay {cant_rango_años}, {cant_bisiestos} de ellos son bisiestos.")

        
# Ejercicio 9 

def crear_lista():
    n = int(input("Ingrese el número de palabras que desea agregar a la lista: "))
    lista = []
    for i in range(n):
        palabra = input(f"Ingrese la palabra número {i+1}: ")
        lista.append(palabra)
    return lista

def main7():
    # llamamos a la función para crear la lista
    mi_lista = crear_lista()

    # imprimimos la lista creada
    print("La lista creada es:", mi_lista)


# Ejercicio 11 
def solicitar_cantidad_listas():
    n = -1
    while n < 0:
        try:
            n = int(input(f"Ingrese cuantas listas quiere escribir: "))            
        except:
            n = -1
            print("La cantidad de listas a crear debe ser un numero entero mayor o igual que 0.")
    
    return n

def crear_lista(nro_lista):
    n = int(input(f"Ingrese el número de palabras que desea agregar a la lista {nro_lista}: "))
    lista = []
    for i in range(n):
        palabra = input(f"Ingrese la palabra número {i+1}: ")
        while (lista.__contains__(palabra)):
            print(f"{palabra} ya esta en lista.")
            palabra = input(f"Ingrese la palabra número {i+1}: ")

        lista.append(palabra)
    return lista

def main8():
    # solicitamos la cantidad de listas a generar
    cant_listas = solicitar_cantidad_listas()

    # llamamos a la función para crear la lista
    for i in range(cant_listas):
        mi_lista = crear_lista(i + 1)

        # imprimimos la lista creada
        print(f"La lista {i+1} es:", mi_lista)


# Ejercicio 12 

def eliminar_elementos_lista(lista_a_modificar, lista_referencia):
    for i in lista_referencia:
        for j in range(len(lista_a_modificar)-1, -1, -1):
            if lista_a_modificar[j] == i:
                del(lista_a_modificar[j])
    print("La lista es ahora:", lista_a_modificar)


def main9():
    # llamamos a la función para crear las 2 listas de palabras
    mi_lista = crear_lista(1)
    # imprimimos la lista creada
    print(f"La lista 1 es:", mi_lista)

    mi_lista2 = crear_lista(2)
    # imprimimos la lista creada
    print(f"La lista 2 de palabras a eliminar es:", mi_lista2)

    eliminar_elementos_lista(mi_lista, mi_lista2)

        


if __name__ == "__main__":
    #main()
    #main3()
    #main4()
    #main5()
    #main6()
    #main7()
    #main8()
    #main9()
    pass


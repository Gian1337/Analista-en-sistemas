import math
import os
'''1- Implementar una función llamada factorial que recibe un entero positivo llamada param_valor. La
función debe calcular la factorial de param_valor y devolver el resultado.
Pruebe el código con estos valores para comprar que funciona'''
os.system("cls")
def factorial(param_valor):
    if param_valor > 0:
        return param_valor * factorial(param_valor - 1)
    else:
        return  1

print(f"El factorial de 5 es {factorial(5)}")
input("Presione ENTER para continuar..")

# ACTIVIDAD 2
os.system("cls")
p1 =  (1,2,3)
p2 = (0,0,0)
def calcularDistancia(punto1, punto2):
    return math.sqrt((punto1[0] - punto2[0])**2 + (punto1[1] - punto2[1])**2 + (punto1[2] - punto2[2])**2)

print(f'La distancia entre los puntos x,y,z desde {p1} hasta {p2} es de {calcularDistancia(p1,p2)}')
input("Presione ENTER para continuar..")

#ACTIVIDAD 3 
import random

os.system("cls")
def valor_aleatorio(inicio, fin):
    return random.randint(inicio, fin)

def menu():
    print("###### MENÚ #####")
    print("1- Tirar la palanca")
    print("2- Salir")

def jugar_tragamonedas():
    pozo = 2000
    fichas_jugador = 300

    while True:
        menu()
        opcion = int(input("Ingrese su opción: "))
        if opcion == 1:
            if fichas_jugador >= 100:
                fichas_jugador -= 100
                pozo += 50

                numero1 = valor_aleatorio(0, 9)
                numero2 = valor_aleatorio(0, 9)
                numero3 = valor_aleatorio(0, 9)

                print(f"{numero1} {numero2} {numero3}")

                if numero1 == numero2 == numero3:
                    fichas_jugador += 200
                    print("¡Ganaste 100 pesos!")
                elif numero1 == numero2 or numero1 == numero3 or numero2 == numero3:
                    fichas_jugador += 25
                    pozo += 50
                    print("¡Ganaste 25 pesos!")
                else:
                    print("Perdiste 100 pesos.")
            else:
                print("No tienes suficientes fichas para seguir jugando.")
                break
        elif opcion == 2:
            print("Gracias por jugar.")
            break
        else:
            print("Opción inválida, por favor ingrese una opción válida.")

        print(f"Pozo: {pozo} pesos")
        print(f"Fichas jugador: {fichas_jugador} pesos")

if __name__ == "__main__":
    jugar_tragamonedas()


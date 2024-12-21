'''
Alumno: Gianluca Carlini
Fecha: 31/05/2024
Ejercicio: Guía de Ejercicios N° 7
Tema: Clases y Objetos
'''

#Ejercicio 1
'''
class Character:
    def __init__(self, x,y ):
        
        self.x = x
        self.y = y
    
personaje1 = Character(20,50)
print(f"El valor de X es: {personaje1.x}")
print(f"El valor de Y es: {personaje1.y}")
'''

#Ejercicio 2
'''
class Auto:
    
    def __init__(self):
        self.x = 0
        self.y = 0
        
    def Dibujar(self):
        print("El auto se está dibujando")
    
    def Mover(self):
        self.x =+ 1
        print("El auto se movió una posición en X")
    

auto1 = Auto()
print(auto1.x)
auto1.Dibujar()
auto1.Mover()
print(auto1.x)
'''

#Ejercicio 3

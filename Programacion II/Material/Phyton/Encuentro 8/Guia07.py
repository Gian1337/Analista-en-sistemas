import os
import time
'''
#--- ACTIVIDAD 1 ---
class Character:
    x = None
    y = None
    
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def dibujar(self):
        print(f"\033[{str(self.y)};{str(self.x)}H*")    

def main():
    os.system('cls')
    personaje = Character(10,0)
    personaje.dibujar()
    input()
        
'''

'''
#ACTIVIDAD 2
class Auto():
    x = None
    y = None
    def __init__(self):
        self.x = 0
        self.y = 0

    def dibujar(self):
        if self.x == 0:
            # La leyenda saldrá solo la primera vez que se dibuje el auto
            print("El auto se esta dibujando...")
            time.sleep(3)
        os.system('cls')
        for x in range(30):
            print(f"\033[0;{str(x)}H_")
        print(f"\033[0;{str(self.x)}Ho-o")

    def mover(self):
        self.x += 1
        if self.x == 30:
            print("El auto llegó a destino")
            self.x = 0
        else:
            self.dibujar()

def main():
    os.system('cls')
    auto = Auto()
    auto.dibujar()
    input("Presione enter para comenzar a mover el auto")
    
    # Bucle para simular el recorrido
    for x in range(30):
        time.sleep(1)
        auto.mover()
 '''   

# ACTIVIDAD 3
class Punto():
    x = None
    y = None
    flagX = False
    flagY = False

    def __init__(self):
        self.x = 0
        self.y = 0
        self.flagX = False
        self.flagY = False
        
    def dibujar(self):
        os.system('cls')
        print(f"\033[{str(self.y)};{str(self.x)}H*")

    def mover(self):
        if self.flagX == True:
            self.x += 1
        else:
            self.x -= 1
        if self.flagY == True:
            self.y += 1
        else:
            self.y -= 1

    def actualizar(self):
        if self.x == 0 and self.y == 0:
            self.flagX = True
            self.flagY = True
        elif self.x == 100 and self.y == 100:
            self.flagX = False 
            self.flagY = False
        self.mover()

def main():
    os.system('cls')
    input('Presiona enter para comenzar')
    puntero = Punto()
    for x in range(300):
        time.sleep(0.5)
        puntero.dibujar()
        puntero.actualizar()


if __name__ == "__main__":
    main()
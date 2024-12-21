import random
import pygame
class Jugador():
    __jugada__ = None
    def __init__(self):
        self.__jugada__ = 0

    def generar(self):
        return random.randint(1,3)

    def toString(self):
        if self.__jugada__ == 1:
            return 'Piedra'
        if self.__jugada__ == 2:
            return 'Papel'
        if self.__jugada__ == 3:
            return 'Tijera'
    
    def modificarJugada(self, jugada):
        self.__jugada__ = jugada

class Humano(Jugador):
    __nombre__ = None
    __jugada__ = None

    def __init__(self):
        self.__nombre__ = None
        self.__jugada__ = None

    def __init__(self, nombre : str):
        self.__nombre__ = nombre
        self.__jugada__ = 0

    def leer_datos(self):
        return self.__nombre__, self.__jugada__
    
    def modificar_datos(self, nombre, jugada):
        self.__nombre__ = nombre
        self.__jugada__ = jugada

    def modificarJugada(self, jugada):
        return super().modificarJugada(jugada)

    def toString(self):
        return super().toString()

    def generar(self, fila, columna, screen):
        fuente = pygame.font.SysFont('Verdana', 20)
        texto1 = fuente.render('¿Que vas a jugar?', True, (0,0,0))
        texto2 = fuente.render('[1 Piedra] [2 Papel] [3 Tijera]', True, (0,0,0))
        screen.blit(texto1, (columna, fila))
        screen.blit(texto2, (columna - 50, fila + 20))
        
class Computadora(Jugador):
    def __init__(self):
        self.__jugada__ = 0
    
    def toString(self):
        return super().toString()
    
    def generar(self):
        return super().generar()
    
    def modificarJugada(self, jugada):
        return super().modificarJugada(jugada)
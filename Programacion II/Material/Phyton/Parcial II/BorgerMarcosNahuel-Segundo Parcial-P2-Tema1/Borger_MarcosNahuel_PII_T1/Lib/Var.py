import pygame
# Lista global con los elementos que se pueden elegir
VALORES = [
    'Piedra',
    'Papel',
    'Tijera'
]

# variables globales de la pantalla
SCREEN_WIDTH = 600
SCREEN_HEIGHT = 400

# Lista de imagenes a utilizar en el juego
# Imagenes a utilizar
IMG_SELECTION = [
    pygame.image.load(".\\Sprites\\Mano\\Piedra.png"),
    pygame.image.load(".\\Sprites\\Mano\\Papel.png"),
    pygame.image.load(".\\Sprites\\Mano\\Tijera.png")
]
IMG_SELECTION[0] = pygame.transform.scale(IMG_SELECTION[0], (100, 100))
IMG_SELECTION[1] = pygame.transform.scale(IMG_SELECTION[1], (100, 100))
IMG_SELECTION[2] = pygame.transform.scale(IMG_SELECTION[2], (80, 80))
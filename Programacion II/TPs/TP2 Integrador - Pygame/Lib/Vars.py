import pygame

# creación de ventana
WIDTH = 500
HEIGHT = 500
screen_size = (WIDTH, HEIGHT)
screen = pygame.display.set_mode(screen_size)
pygame.display.set_caption('Interstellar')

# coordenadas lineas 
lineaIzq = 150
lineaCentral = 250
lineaDer = 350
lineas = [lineaIzq, lineaCentral, lineaDer]


# Coordenadas iniciales del jugador
player_x = 250
player_y = 400


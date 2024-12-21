from Lib import Core, Var
from datetime import datetime
import pygame

#Función para consultar el ganador de la partida
def consultarGanador(Jugador : Core.Humano, Computadora : Core.Computadora):
    if Jugador.toString() == Computadora.toString():
        registrarGanador('EMPATE')
        return 'Empate'
    elif Jugador.toString() == 'Piedra':
        if Computadora.toString() == 'Papel':
            registrarGanador('Computadora')
            return 'Gana la computadora!'
        else:
            registrarGanador(Jugador.leer_datos()[0])
            return 'Ganaste!'
    elif Jugador.toString() == 'Papel':
        if Computadora.toString() == 'Tijera':
            registrarGanador('Computadora')
            return 'Gana la computadora!'
        else:
            registrarGanador(Jugador.leer_datos()[0])
            return 'Ganaste!'
    elif Jugador.toString() == 'Tijera':
        if Computadora.toString() == 'Piedra':
            registrarGanador('Computadora')
            return 'Gana la computadora!'
        else:
            registrarGanador(Jugador.leer_datos()[0])
            return 'Ganaste!'
        
# Carga del ganador en un archivo
def registrarGanador(nombreGanador):
    fecha = datetime.now().strftime("%d/%m/%Y %H:%M:%S")
    archivo = open('.\\Saves\\partidas.txt', 'a')
    if nombreGanador != 'EMPATE':
        archivo.write(f'{fecha}, Ganador {nombreGanador}\n')
    else:
        archivo.write(f'{fecha}, {nombreGanador}\n')
    archivo.close()

# Muestra todas las opciones para elegir
def mostrarElecciones(screen : pygame.display):
    screen.blit(Var.IMG_SELECTION[0], (120, 150))
    screen.blit(Var.IMG_SELECTION[1], (240, 150))
    screen.blit(Var.IMG_SELECTION[2], (370, 160))

# Muestra las opciones elegidas por los jugadores
def mostrarSeleccionJugador(humano : Core.Humano, computadora : Core.Computadora, screen : pygame.display):
    fuente = pygame.font.SysFont('Verdana', 40)
    if humano.toString() != None:
        if humano.toString() == 'Piedra':
            screen.blit(Var.IMG_SELECTION[0], (100, 210))
        elif humano.toString() == 'Papel':
            screen.blit(Var.IMG_SELECTION[1], (100, 210))
        elif humano.toString() == 'Tijera':
            screen.blit(Var.IMG_SELECTION[2], (100, 210))
        texto1 = fuente.render('TU', True, (0,0,0))
        screen.blit(texto1, (30, 230))
    if computadora.toString() != None:
        if computadora.toString() == 'Piedra':
            screen.blit(Var.IMG_SELECTION[0], (400, 210))
        elif computadora.toString() == 'Papel':
            screen.blit(Var.IMG_SELECTION[1], (400, 210))
        elif computadora.toString() == 'Tijera':
            screen.blit(Var.IMG_SELECTION[2], (400, 210))
        texto2 = fuente.render('PC', True, (0,0,0))
        screen.blit(texto2, (530, 230))
    
    

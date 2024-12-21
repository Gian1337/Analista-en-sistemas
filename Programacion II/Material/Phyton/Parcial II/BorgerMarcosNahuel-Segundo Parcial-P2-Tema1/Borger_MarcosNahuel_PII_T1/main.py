import pygame
from Lib import Core, Var, Func

def main():
    # Inicializamos a los jugadores
    computadora = Core.Computadora()
    humano = Core.Humano(str(input('Ingrese su nombre: ')))

    pygame.init()

    # Definimos la pantalla
    screen = pygame.display.set_mode((Var.SCREEN_WIDTH,Var.SCREEN_HEIGHT))
    screen.fill((199, 244, 247))
    img_fondo = pygame.image.load(".\\Sprites\\Fondo\\Fondo.jpg")
    img_fondo = pygame.transform.scale(img_fondo, pygame.display.get_window_size())
    pygame.display.set_caption('PIEDRA-PAPEL-TIJERA')

    # Intanciamos el clock
    clock = pygame.time.Clock()

    # Definimos variables a utilizar luego en la logica del juego
    fuente = pygame.font.SysFont('Verdana', 20)
    fuente2 = pygame.font.SysFont('Verdana', 30)
    temporizador_iniciado = False
    eleccion_pc = None
    ganador = None
    jugando = True
    turno = True
    pausa = False

    while jugando:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                jugando = False
            if not pausa:
                if turno:
                    # Turno del humano
                    timer = 0
                    screen.blit(img_fondo, (0,0))
                    Func.mostrarElecciones(screen)
                    humano.generar(100, 200 , screen)
                    if event.type == pygame.KEYDOWN:
                        if event.key == pygame.K_1:
                            humano.modificarJugada(1)
                            turno = False
                        if event.key== pygame.K_2:
                            humano.modificarJugada(2)
                            turno = False
                        if event.key == pygame.K_3:
                            humano.modificarJugada(3)
                            turno = False  
                        print(f'Elegiste {humano.toString()}')
                else:
                    #Inicializamos el temporizador
                    timer = pygame.time.get_ticks()
                        
                    #Mostramos el texto de turno oponente
                    screen.blit(img_fondo, (0,0))
                    texto1 = fuente.render('TURNO DEL OPONENTE', True, (0,0,0))
                    screen.blit(texto1, (200, 120))
                    Func.mostrarSeleccionJugador(humano, computadora, screen)

                    # Timer para generar una pequeña pausa
                    tiempo = (timer - tiempo_inicio) // 1000
                    if tiempo >= 3:
                        timer = 0
                        temporizador_iniciado = False
                        eleccion_pc = computadora.generar()
                        computadora.modificarJugada(eleccion_pc)
                        print(f'La computadora elegió {computadora.toString()}')
                        turno = True
                        pausa = True
                
                # Tomamos una muestra de tiempo cuando es el turno del oponente para el temporizador
                if not turno and not temporizador_iniciado:
                    temporizador_iniciado = True
                    tiempo_inicio = pygame.time.get_ticks()
            else:
                if ganador == None:
                    #Si no esta definido el ganador, se consulta
                    ganador = Func.consultarGanador(humano, computadora)
                else:
                    # Si se sabe el ganador, se muestra por pantalla y se muestra lo que seleccionaron ambos
                    screen.blit(img_fondo, (0,0))
                    Func.mostrarSeleccionJugador(humano, computadora, screen)
                    
                    texto1 = fuente2.render(ganador, True, (0, 0, 0))
                    texto2 = fuente.render('Presiona R para volver a jugar', True, (0, 0, 0))
                    screen.blit(texto1,(160, 100))
                    screen.blit(texto2,(160, 130))

                    if event.type == pygame.KEYDOWN:
                        if event.key == pygame.K_r:
                            pausa = False
                            print('Se reanuda el juego')
                            ganador = None
                            humano.modificarJugada(None)
                            computadora.modificarJugada(None)

            

            clock.tick(60)
            pygame.display.update()
if __name__ == '__main__':
    main()
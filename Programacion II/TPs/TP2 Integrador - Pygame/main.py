import pygame
import sys
from pygame.locals import *
import random
from Lib.Colors import *
from Lib.Vars import *
from Lib.Core import *

def main():
    pygame.init()
    
    #Inicializa música
    pygame.mixer.init()
    pygame.mixer.music.load('Sprites/Sounds/music.mp3')
    pygame.mixer.music.play(loops=-1)
    
    #Sonido de colisión
    collision_sound = pygame.mixer.Sound('Sprites/Sounds/boom-sound.mp3')
     
    #Background
    background_image = pygame.image.load('Sprites/Background/spacecraft.jpeg')
    background_image = pygame.transform.scale(background_image, (WIDTH, HEIGHT))

    # Función para mostrar la pantalla inicial
    def pantalla_inicio():
        
        screen.blit(background_image, (0, 0))
        font = pygame.font.Font(pygame.font.get_default_font(), 36)
        
        text = font.render('Bienvenido!', True, blanco)
        text_rect = text.get_rect(center=(WIDTH // 2, HEIGHT // 2.2))
        screen.blit(text, text_rect)
        
        play_button = pygame.Rect(WIDTH // 4, HEIGHT // 2, WIDTH // 2, 50)
        quit_button = pygame.Rect(WIDTH // 4, HEIGHT // 2 + 70, WIDTH // 2, 50)
        
        pygame.draw.rect(screen, verde, play_button)
        pygame.draw.rect(screen, rojo, quit_button)
        
        play_text = font.render('Jugar', True, blanco)
        quit_text = font.render('Salir', True, blanco)
        
        play_text_rect = play_text.get_rect(center=play_button.center)
        quit_text_rect = quit_text.get_rect(center=quit_button.center)
        
        screen.blit(play_text, play_text_rect)
        screen.blit(quit_text, quit_text_rect)
        
        pygame.display.update()

        waiting = True
        while waiting:
            for event in pygame.event.get():
                if event.type == QUIT:
                    pygame.quit()
                    exit()
                if event.type == MOUSEBUTTONDOWN:
                    if play_button.collidepoint(event.pos):
                        waiting = False
                    elif quit_button.collidepoint(event.pos):
                        pygame.quit()
                        exit()
                        
    pantalla_inicio()
    
    # sprite groups
    player_group = pygame.sprite.Group()
    obj_group = pygame.sprite.Group()

    # Crea el jugador
    player = PlayerObjeto(player_x, player_y)
    player_group.add(player)

    # Carga de objetos
    image_filenames = ['rock.png', 'saturn.png', 'ovni.png', 'earth.png', 'satellite.png', 'meteor.png']
    objs_images = []
    for image_filename in image_filenames:
        image = pygame.image.load('Sprites/Objetos/' + image_filename)
        objs_images.append(image)

    # Carga explosión
    crash = pygame.image.load('Sprites/Objetos/crash.png')
    crash_rect = crash.get_rect()

    # Variables de juego
    running = True
    gameover = False
    velocidad = 2
    puntaje = 0
    clock = pygame.time.Clock()
    fps = 120
    
    
    # game loop
    while running:
        clock.tick(fps)

        for event in pygame.event.get():
            if event.type == QUIT:
                running = False
            
            # Movimientos usando flechas <- ->
            if event.type == KEYDOWN:
                if event.key == K_LEFT and player.rect.center[0] > lineaIzq:
                    player.rect.x -= 100
                elif event.key == K_RIGHT and player.rect.center[0] < lineaDer:
                    player.rect.x += 100
                
                # Check de colision
                for obj in obj_group:
                    if pygame.sprite.collide_rect(player, obj): #Comprueba si hay colisión entre el player y el objeto
                        collision_sound.play()
                        gameover = True
                        #pygame.mixer.music.play()
                        
                        #Ajuste de posiciones si colisionan para evitar que el player quede superpuesto con el objeto.
                        if event.key == K_LEFT:
                            player.rect.left = obj.rect.right
                            crash_rect.center = [player.rect.left, (player.rect.center[1] + obj.rect.center[1]) / 2]
                            
                        elif event.key == K_RIGHT:
                            player.rect.right = obj.rect.left
                            crash_rect.center = [player.rect.right, (player.rect.center[1] + obj.rect.center[1]) / 2]
                            

        # Dibuja el espacio
        screen.fill(negro)
        
        #Dibuja el objeto del jugador
        player_group.draw(screen)
        
        # Agrega un objeto
        if len(obj_group) < 2:
            add_obj = True
            for obj in obj_group:
                if obj.rect.top < obj.rect.height * 1.5: #Comprueba objeto esté a una distsancia menor a 1.5 veces la altura del rect desde top
                    add_obj = False
            
            if add_obj:
                #Selecciona una nueva linea vertical
                linea = random.choice(lineas)
                #Selecciona un objeto
                image = random.choice(objs_images)
                obj = Objeto(image, linea, HEIGHT / -2)
                obj_group.add(obj)
        
        # Genera movimiento de objetos
        for obj in obj_group:
            #Incrementa la posicion vertical en funcion de la velocidad
            obj.rect.y += velocidad
            
            #Comprueba si el objeto salió por la parte inferior de la pantalla
            if obj.rect.top >= HEIGHT:
                obj.kill()
                puntaje += 1
                if puntaje > 0 and puntaje % 5 == 0:
                    velocidad += 1
        
        # Dibuja los objetos
        obj_group.draw(screen)
        
        # Muestra el puntaje
        fuente = pygame.font.Font(pygame.font.get_default_font(), 16)
        text = fuente.render('Puntaje: ' + str(puntaje), True, blanco)
        text_rect = text.get_rect()
        text_rect.center = (50, 400)
        screen.blit(text, text_rect)
        
        if pygame.sprite.spritecollide(player, obj_group, True):
            collision_sound.play()
            gameover = True
            crash_rect.center = [player.rect.center[0], player.rect.top]
        
        # muestra pantalla game over
        if gameover:
            screen.blit(crash, crash_rect)
            pygame.draw.rect(screen, rojo, (0, 50, WIDTH, 100))
            font = pygame.font.Font(pygame.font.get_default_font(), 16)
            text = font.render('Game over. Jugar de nuevo? (Ingrese S o N)', True, blanco)
            text_rect = text.get_rect()
            text_rect.center = (WIDTH / 2, 100)
            screen.blit(text, text_rect)
            pygame.mixer.music.stop()
            pygame.mixer.quit()
        pygame.display.update()

        while gameover:
            clock.tick(fps)
            for event in pygame.event.get():
                if event.type == QUIT:
                    gameover = False
                    running = False
                
                # Input (S ó N)
                if event.type == KEYDOWN:
                    if event.key == K_s:
                        # reset
                        gameover = False
                        velocidad = 2
                        puntaje = 0
                        obj_group.empty()
                        player.rect.center = [player_x, player_y]
                        pygame.mixer.init()
                        pygame.mixer.music.load('Sprites/Sounds/music.mp3')
                        pygame.mixer.music.play(-1)
                    elif event.key == K_n:
                        # exit 
                        gameover = False
                        running = False
    pygame.quit()
    sys.exit()
if __name__ == "__main__":
    main()


import pygame
import time
import Lib.Color as Color
import Lib.Core as core
import Lib.Var as Var
def reset_game(objects : list):
    for obj in objects:
        obj.respawn()

def main():
    pygame.init()

    # Propiedades de la ventana
    screen = pygame.display.set_mode((Var.SCREEN_WIDTH, Var.SCREEN_HEIGHT))
    pygame.display.set_caption('No brakes')

    # Background o escenario de fondo del juego
    img_background = pygame.image.load('Background/Background.jpg')
    img_background = pygame.transform.scale(img_background, pygame.display.get_window_size())
    img_background_x = 0

    # Clock
    clock = pygame.time.Clock()

    # Instanciando objetos
    character = core.Character()
    letrero = core.Letrero()
    hidrante = core.Hidrante()
    car = core.Car()
    coin = core.Coin()

    objetos = [character, letrero, hidrante, car, coin]
    _list_Sprite = pygame.sprite.Group()
    for obj in objetos:
        _list_Sprite.add(obj)
    
    # Variables del juego
    score = 0
    ejecutando = True
    game_over = False
    game_pause = False
    while ejecutando:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                ejecutando = False
            elif event.type == pygame.KEYDOWN:
                if event.key == pygame.K_w:
                    character.jump()
                if event.key == pygame.K_SPACE:
                    character.jump()
                if event.key == pygame.K_r:
                    reset_game(objetos)
                    score = 0
                    img_background_x = 0
                if event.key == pygame.K_ESCAPE:
                    game_pause = not game_pause
                if event.key == pygame.K_r:
                    reset_game(objetos)
                    score = 0
                    game_over = False
                    img_background_x = 0

        if not game_pause :
            if not game_over : 
                
                # Producimos movimiento en el fondo
                img_background_x -= Var.velocidad
                if img_background_x <= -img_background.get_width():
                    img_background_x = 0
                screen.blit(img_background,(img_background_x, 0))
                screen.blit(img_background, (img_background_x + img_background.get_width(),0))
                
                _list_Sprite.update()
                _list_Sprite.draw(screen)

                # Detección de colisiones entre el PJ y cualquier elemento del juego
                colisiones = pygame.sprite.spritecollide(character, _list_Sprite, False)
                if len(colisiones) > 0 :
                    for sprite in colisiones :
                        if isinstance(sprite, (core.Letrero, core.Hidrante, core.Car)):
                            if character.hitbox.colliderect(sprite.hitbox):
                                if character.hitbox.right > sprite.hitbox.left:
                                    character.rect.right = sprite.hitbox.left
                        if isinstance(sprite, (core.Coin)):
                            if character.hitbox.colliderect(sprite.hitbox):
                                score += 300
                                sprite.respawn()

                # Se detecta la colision entre los objetos obstaculos y se los mueve
                for obj in objetos:
                    if not isinstance(obj, (core.Character, core.Car)):
                        objColision = pygame.sprite.spritecollide(obj, _list_Sprite, False)
                        objColision = [obj for obj in objColision if not isinstance(obj, (core.Character, core.Car))]
                        objColision.remove(obj)
                        if objColision:
                            print(f'Colision en objeto {obj}')
                            obj.rect.x += 700

                # Si el jugador sale de la pantalla por colisionar pierde
                if character.hitbox.x + 50 < 0:
                    game_over = True

                score += 1
                fontScore = pygame.font.SysFont("Verdana", 20)
                textScore = fontScore.render("Points:" + str(score), True, (255, 255, 255))
                screen.blit(textScore, (Var.SCREEN_WIDTH - 150, 0))
                if score > 0 and score % 500 == 0 :
                    Var.aumentarVelocidad()
                
                '''# METODO  PARA DIBUJAR LAS HITBOX
                for obj in objetos:
                    obj.draw_hitbox(screen)'''

        if game_pause :
            font = pygame.font.SysFont("Verdana", 60, italic= True)
            text = font.render('Paused', True, (255, 255, 255))
            screen.blit(text, dest= (screen.get_rect().centerx - text.get_rect().width // 2, screen.get_rect().centery - 30))
            font2 = pygame.font.SysFont("Verdana", 20)
            text2 = font2.render('Press SCAPE to continue', True, (255,255,255))
            screen.blit(text2, dest= (screen.get_rect().centerx - 10 - text.get_rect().width // 2, screen.get_rect().centery + 60))
            
        if game_over :
            font = pygame.font.SysFont("Verdana", 60)
            text = font.render('Game Over', True, (255, 0, 0))
            screen.blit(text, dest= (screen.get_rect().centerx - text.get_rect().width // 2, screen.get_rect().centery - 30))
            font2 = pygame.font.SysFont("Verdana", 20)
            text2 = font2.render('Press R to restart', True, (255,255,255))
            screen.blit(text2, dest= (screen.get_rect().centerx + 60 - text.get_rect().width // 2, screen.get_rect().centery + 40))

        clock.tick(60)
        pygame.display.update()

if __name__ == '__main__':
    main()
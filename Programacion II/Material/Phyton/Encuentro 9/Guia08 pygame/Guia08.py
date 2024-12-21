import pygame, time



#Colores
BLANCO = (255,255,255)
NEGRO = (0,0,0)

class Dino(pygame.sprite.Sprite):
    _lista_animaciones=[]
    _pos_anim = 0
    def __init__(self, position : tuple):
        super().__init__()
        self.image = pygame.Surface([94,128])
        self.rect = self.image.get_rect()
        self.rect.x = position[0] # Posición en X
        self.rect.y = position[1] # Posición en Y
        self._lista_animaciones.append(pygame.image.load(".\\Sprites\\Dino2.png"))
        self._lista_animaciones.append(pygame.image.load(".\\Sprites\\Dino3.png"))
        self.image = self._lista_animaciones[self._pos_anim]

    def update(self):
        time.sleep(0.1)
        self._pos_anim += 1
        if self._pos_anim > 1:
            self._pos_anim = 0
        self.image = self._lista_animaciones[self._pos_anim]
        self.image.set_colorkey((63,202,201))

class Ave(pygame.sprite.Sprite):
    _lista_animaciones = []
    _pos_anim = 0

    def __init__(self, position : tuple):
        super().__init__()
        self.image = pygame.Surface([95,80])
        self.rect = self.image.get_rect()
        self.rect.x = position[0]
        self.rect.y = position[1]
        self._lista_animaciones.append(pygame.image.load(".\\Sprites\\Ave1.png"))
        self._lista_animaciones.append(pygame.image.load(".\\Sprites\\Ave2.png"))
        self.image = self._lista_animaciones[self._pos_anim]
    
    def update(self):
        time.sleep(0.1)
        self._pos_anim +=1
        if self._pos_anim > 1:
            self._pos_anim = 0
        self.image = self._lista_animaciones[self._pos_anim]
        self.image.set_colorkey((64,202,201))

class Plataforma(pygame.sprite.Sprite):
    def __init__(self, position : tuple):
        super().__init__()
        self.image = pygame.Surface([1203, 23])
        self.rect = self.image.get_rect()
        self.rect.x = position[0]
        self.rect.y = position[1]
        self.image = pygame.image.load(".\\Sprites\\Plataforma.png")
        self.image.set_colorkey((64,202,201))

class Fondo(pygame.sprite.Sprite):
    def __init__(self, position : tuple):
        super().__init__()
        self.image = pygame.Surface([422,28])
        self.rect = self.image.get_rect()
        self.rect.x = position[0]
        self.rect.y = position[1]
        self.image = pygame.image.load(".\\Sprites\\fondo.png")
        self.image.set_colorkey((64,202,201))

class Nube(pygame.sprite.Sprite):
    def __init__(self, position : tuple):
        super().__init__()
        self.image = pygame.Surface([110,51])
        self.rect = self.image.get_rect()
        self.rect.x = position[0]
        self.rect.y = position[1]
        self.image = pygame.image.load(".\\Sprites\\nube.png")
        self.image.set_colorkey((64,202,201))

class Cactus(pygame.sprite.Sprite):
    def __init__(self, position : tuple):
        super().__init__()
        self.image = pygame.Surface([110,51])
        self.rect = self.image.get_rect()
        self.rect.x = position[0]
        self.rect.y = position[1]
        self.image = pygame.image.load(".\\Sprites\\cactus.png")
        self.image.set_colorkey((64,202,201))

def main():
    pygame.init()
    
    #Propiedades de la ventana
    width_screen = 600
    height_screen = 400
    pantalla = pygame.display.set_mode((width_screen, height_screen))
    pygame.display.set_caption("Guia 08 pygame")

    #Clock
    clock = pygame.time.Clock() 
    
    # Elementos del juego
    dino = Dino(position= (100, height_screen / 2)) 
    ave = Ave(position= (300, height_screen / 2)) 
    plataforma = Plataforma(position= (0,dino.rect.y + dino.image.get_height() -10))
    fondo = Fondo(position= (0, height_screen / 2))
    fondo2 = Fondo(position= (fondo.image.get_width(), height_screen / 2))
    nube = Nube(position=(width_screen - 200 , height_screen / 3))
    cactus = Cactus(position=(20, plataforma.rect.y - 50))
    cactus2 = Cactus(position=(width_screen - 100, plataforma.rect.y - 80))

    _lista_sprite = pygame.sprite.Group()
    _lista_sprite.add([
        plataforma,
        fondo,
        fondo2,
        dino,
        ave,
        nube,
        cactus,
        cactus2
    ])

    ejecutando = True
    while ejecutando:
        for evento in pygame.event.get():
            if evento.type == pygame.QUIT:
                ejecutando = False
        pantalla.fill(BLANCO)
        _lista_sprite.update()
        _lista_sprite.draw(pantalla)
        clock.tick(30)
        pygame.display.flip()


if __name__ == '__main__':
    main()
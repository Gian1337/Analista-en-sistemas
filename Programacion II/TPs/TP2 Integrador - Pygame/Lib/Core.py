import pygame

#Clase para objetos sprite
class Objeto(pygame.sprite.Sprite):
    
    def __init__(self, image, x, y):
        pygame.sprite.Sprite.__init__(self)
        
        image_scale = 45 / image.get_rect().width
        new_width = image.get_rect().width * image_scale
        new_height = image.get_rect().height * image_scale
        self.image = pygame.transform.scale(image, (new_width, new_height))
        
        self.rect = self.image.get_rect()
        self.rect.center = [x, y]
        
#Clase para el objeto del jugador
class PlayerObjeto(Objeto):
    
    def __init__(self, x, y):
        image = pygame.image.load('Sprites/Objetos/ship.png')
        super().__init__(image, x, y)
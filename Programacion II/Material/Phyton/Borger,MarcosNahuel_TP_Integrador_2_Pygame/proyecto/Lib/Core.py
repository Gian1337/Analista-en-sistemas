from typing import Any
import pygame
import time
from Lib import Var, Color
import random

class Character(pygame.sprite.Sprite):
    _list_anim = []
    _pos_anim = 0
    def __init__(self):
        super().__init__()
        self.image = pygame.Surface([640, 640])
        self._load_image()
        self.image = pygame.transform.scale(self._list_anim[self._pos_anim], (100, 100))
        self.rect = self.image.get_rect()
        self.rect.x = 150
        self.rect.y = 240
        self.jumping = False
        self.vel_jump = 0
        self.gravedad = 0.5
        self.hitbox = self.rect.inflate(-40, -5)

    def _load_image(self):
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Personaje/Personaje_1.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Personaje/Personaje_2.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Personaje/Personaje_3.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Personaje/Personaje_4.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Personaje/Personaje_5.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Personaje/Personaje_6.png').convert_alpha())


    def update(self):
        time.sleep(0.05)
        self._pos_anim += 1
        if self._pos_anim > 5:
            self._pos_anim = -1
        self.image = self.image = pygame.transform.scale(self._list_anim[self._pos_anim],  (100, 100))

        if self.jumping:
            self.image = pygame.transform.scale(self._list_anim[0],  (100, 100))
            self.vel_jump += self.gravedad
            self.rect.y += self.vel_jump
            if self.rect.y >= 240:
                self.rect.y = 240
                self.jumping = False
                self.vel_jump = -10
                self.hitbox = self.rect.inflate(-40, -5)
        
        self.hitbox.x = self.rect.x + 20
        self.hitbox.y = self.rect.y
        self.image.set_colorkey(Color.BLANCO)
    
    def jump(self):
        if not self.jumping:
            self.vel_jump += self.gravedad
            self.jumping = True
            self.vel_jump = -10
            self.hitbox = self.hitbox.inflate(0,-20)

    def draw_hitbox(self, screen):
        pygame.draw.rect(screen, (255, 255, 0), self.hitbox, 2)

    def respawn(self):
        self.rect.x = 150

class Letrero(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
        self.image = pygame.Surface([768,768])
        self.image = pygame.image.load('/proyecto/Sprites/Letrero/Signal.png').convert_alpha()
        self.image = pygame.transform.scale(self.image, (150, 150))
        self.rect = self.image.get_rect()
        self.rect.x = 800
        self.rect.y = 220
        self.hitbox = self.rect.inflate(-110, -80)
        self.image.set_colorkey(Color.BLANCO)
    
    def update(self):
        self.rect.x -= Var.velocidad
        if self.rect.x < -200:
            self.rect.x = random.randint(900, 1200)
        self.hitbox.x = self.rect.x + 50
    
    def draw_hitbox(self, screen):
        pygame.draw.rect(screen, (255, 255, 0), self.hitbox, 2)

    def respawn(self):
        self.rect.x = 800

class Hidrante(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
        self.image = pygame.Surface([512, 512])
        self.image = pygame.image.load('/proyecto/Sprites/Hidrante/Hidrante.png')
        self.image = pygame.transform.scale(self.image, (80, 80))
        self.rect = self.image.get_rect()
        self.rect.x = 1200
        self.rect.y = 270
        self.hitbox = self.rect.inflate(-60, -30)
        self.image.set_colorkey(Color.BLANCO)

    def update(self):
        self.rect.x -= Var.velocidad
        if self.rect.x < -200:
            self.rect.x = random.randint(1200, 1600)
        self.hitbox.x = self.rect.x + 30

    def draw_hitbox(self, screen):
        pygame.draw.rect(screen, (255, 255, 0), self.hitbox, 2)

    def respawn(self):
        self.rect.x = 1200

class Car(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
        self.image = pygame.Surface([640, 430])
        self.image = pygame.image.load('/proyecto/Sprites/Car/Car.png')
        self.image = pygame.transform.scale(self.image, (200, 200))
        self.rect = self.image.get_rect()
        self.rect.x = 20000
        self.rect.y = 220
        self.hitbox = self.rect.inflate(-50, -130)
        self.image.set_colorkey(Color.BLANCO)

    def update(self):
        self.rect.x -= Var.velocidad * 3
        if self.rect.x < -200 :
            self.rect.x = random.randint(20000, 30000)
        self.hitbox.x = self.rect.x + 20

    def draw_hitbox(self, screen) :
        pygame.draw.rect(screen, (255, 255, 0), self.hitbox, 2)

    def respawn(self):
        self.rect.x = 20000

class Coin(pygame.sprite.Sprite):
    _list_anim = []
    _pos_anim = 0
    def __init__(self):
        super().__init__()
        self.image = pygame.Surface([640, 640])
        self._load_image()
        self.image = pygame.transform.scale(self._list_anim[self._pos_anim], (50, 50))
        self.rect = self.image.get_rect()
        self.rect.x = 3000
        self.rect.y = 250
        self.jumping = False
        self.vel_jump = 0
        self.gravedad = 0.5
        self.hitbox = self.rect.inflate(-10, -10)
 
    def _load_image(self):
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Coin/Coin1.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Coin/Coin2.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Coin/Coin3.png').convert_alpha())
        self._list_anim.append(pygame.image.load('/proyecto/Sprites/Coin/Coin4.png').convert_alpha())

    def update(self):
        self.rect.x -= Var.velocidad
        self.hitbox.x = self.rect.x + 2
        self._pos_anim += 1
        if self._pos_anim > 3:
            self._pos_anim = -1
        self.image = self.image = pygame.transform.scale(self._list_anim[self._pos_anim],  (50, 50))

        if self.rect.x < -200:
            self.rect.x = random.randint(Var.SCREEN_WIDTH, 10000)

    def draw_hitbox(self, screen) :
        pygame.draw.rect(screen, (255, 255, 0), self.hitbox, 2)

    def respawn(self):
        self.rect.x = random.randint(5000, 10000)
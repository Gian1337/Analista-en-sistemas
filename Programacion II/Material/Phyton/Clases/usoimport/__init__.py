# Diferentes usos del import

# Traer una liberia completa
import os

# Traer una libreria o funciones propias
# Si esta en otra carpeta sería carpeta.lib 
import lib as milib

# Traer solo una funcion en concreto de una libreria
from math import sqrt


'''
SU USO
'''

def main():
    print(f"La suma de 3 + 3 es {milib.sumar(3,3)}")
    input()

if __name__ == '__main__':
    main()
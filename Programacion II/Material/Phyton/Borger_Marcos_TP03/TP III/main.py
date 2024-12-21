import pandas as pd
import matplotlib as mp
import os
from Lib import Core


def main():
    os.system('cls')
    print('BIENVENIDO!')
    print('¿Que datos desea observar?')
    print('1- Monotributistas activos por año')
    print('2- Monotributistas activos por provincia en determinado periodo')
    print('3- Efectores pagos por mes en el periodo 2021')
    print()
    opcion = int(input())
    if opcion == 1:
        Core.mostrarActivos()
    elif opcion == 2:
        os.system('cls')
        print('Monotributistas activos por provincia en determinado periodo')
        print('Periodos disponibles: ')
        for numPeriodo in range(2012, 2023):
            print(f'- {numPeriodo}')
        periodo = int(input('Ingrese el periodo que desea observar: '))
        if periodo in range(2012, 2023):
            rta = str(input('¿Filtrar los datos de la provincia de Buenos Aires? (S/N): '))
            if rta == 's':
                Core.mostrarActivosProvincia(periodo, True)
            else:
                Core.mostrarActivosProvincia(periodo, False)   
        else:
            print('El periodo especificado no existe.')
    if opcion == 3:
        Core.mostrarTotalActivosPeriodo()

if __name__ == '__main__':
    main()
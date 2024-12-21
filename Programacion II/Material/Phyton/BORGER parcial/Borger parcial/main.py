'''
    PRIMER PARCIAL PRACTICO PROGRAMACIÓN II
    Nombre del archivo: main.py
    Descripción: Sistema de información para un departamento de recursos humanos.
    Autor: Borger, Marcos Nahuel
    Fecha: 17/05/2023
'''
import sys
import os
from func.funcionesEmp import *

def main():
    mostrarPanel()
    opcion = int(input('\nIngrese su opcion: '))
    if opcion == 1: solicitarDatosEmpleado()
    elif opcion == 2: mostrarEmpleados()
    elif opcion == 3: calcularSalarioPromedio()
    elif opcion == 4: buscarEmpleado()
    elif opcion == 5: sys.exit()
def mostrarPanel():
    os.system('cls')
    print('\033[0;30HSISTEMA')
    for i in range(70):
        print('-', end='')
    print('\n')
    print('\033[3;25HSeleccione una opción:\n 1- Registar empleado \n 2- Listar empleados \n 3- Calcular salario promedio \n 4- Buscar empleado por nombre \n 5- Salir')
    for x in range(70):
        print('-', end='')

def buscarEmpleado():
    os.system('cls')
    listaEmpleados = obtenerEmpleados()
    if len(listaEmpleados) != 0:
        nombre = str(input('Ingrese el nombre del empleado: '))
        listaBusqueda = []
        for empleado in listaEmpleados:
            if empleado[0] == nombre:
                listaBusqueda.append(empleado)
        if listaBusqueda != 0:
            print(f'{len(listaBusqueda)} elemento/s coinciden con su busqueda: ')
            for empleadoBusqueda in listaBusqueda:
                print(f'{str(empleadoBusqueda[0])}, {str(empleadoBusqueda[1])}, ${str(empleadoBusqueda[2])}')
            input('Pulse ENTER para continuar')
            main()
        else:
            print('No se han encontrado resultados en su busqueda.')
            input('Pulse ENTER para continuar')
            main()
    else:
        print('Aún no se encuentran empleados registrados en el sistema')
        input('Pulse ENTER para volver')
        main()

def calcularSalarioPromedio():
    os.system('cls')
    listaEmpleados = obtenerEmpleados()
    if len(listaEmpleados) != 0:
        totalSalarios = 0
        for empleado in listaEmpleados:
            totalSalarios += float(empleado[2])
        salarioPromedio = totalSalarios / len(listaEmpleados)
        print(f'El salario promedio entre todos los empleados es de ${round(salarioPromedio,2)}')
        input('Pulse ENTER para continuar')
        main()
    else:
        print('Aún no se encuentran empleados registrados para calcular un promedio')
        input('Pulse ENTER para volver')
        main()

def mostrarEmpleados():
    os.system('cls')
    listaEmpleados = obtenerEmpleados()
    if len(listaEmpleados) != 0:
        print('Empleados registrador en el sistema:')
        for empleado in listaEmpleados:
            print(f'{str(empleado[0])}, {str(empleado[1])}, ${str(empleado[2])}')
        input('Pulse ENTER para continuar')
        main()
    else:
        print('Aún no se encuentran empleados registrados')
        input('Pulse ENTER para volver')
        main()

def solicitarDatosEmpleado():
    try:
        os.system('cls')
        print('Ingrese los datos del empleado.')
        nombreEmp = str(input('Ingrese el nombre: '))
        apellidoEmp = str(input('Ingrese el apellido: '))
        salarioEmp = float(input('Ingrese el salario: '))
        empleado = [nombreEmp, apellidoEmp, salarioEmp]
        if registrarEmpleado(empleado) == True:
            print('Empleado registrado con exito!')
            input('Pulse ENTER para continuar')
            main()
        else:
            print('Error al registrar el empleado, compruebe los datos')
            input('Pulse ENTER para continuar')
            main()
    except ValueError:
        print(f'[ERROR] valor invalido ingresado')
        input('Pulse ENTER para volver')
        main()
        


if __name__ == '__main__':
    main()
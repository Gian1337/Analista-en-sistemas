def registrarEmpleado(empleado : tuple):
    if (empleado[0] and empleado[1] != '') and (empleado[2] > 0):
        archivo = open('archivo.txt', 'a')
        archivo.write(f'{empleado[0]},{empleado[1]},{empleado[2]} \n')
        archivo.close()
        return True
    else:
        return False
    
def obtenerEmpleados():
    archivo = open('archivo.txt', 'r')
    if archivo.readline:
        listaEmpleados = []
        for line in archivo.readlines():
            data = line.split(',')
            empleado = (data[0], data[1], float(data[2]))
            listaEmpleados.append(empleado)
        archivo.close()
        return listaEmpleados
    else:
        return None



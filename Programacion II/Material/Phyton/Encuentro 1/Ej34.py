'''
34- Ingresar por teclado un valor entero, para asignarlo a una variable llamada temperatura. Luego ingresar una cadena para
asignarla a una variable llamada localidad. mostrar en pantalla la leyenda en la zona .... Tenemos una temperatura de .....
(usar los comodines %)
'''

temperatura = int(input("Ingrese la temperatura actual: "))
localidad = input("Ingrese el nombre de la localidad: ")

print("En la zona de %s tenemos una temperatura de %d grados." % (localidad,temperatura))
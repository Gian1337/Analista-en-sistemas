'''
Alumno: Gianluca Carlini
Ejercicio: Guía de Ejercicios N° 14
Tema: Clases y Objetos
'''
import random

#Ejercicio 1,2,3,4,5
'''
class Persona:
    _nombre = None
    _edad = None
    
    def __init__(self, nombre=None, edad=None):
        self._nombre = nombre
        self._edad = edad
    
    def get_Nombre(self):
        return self._nombre
    
    def set_Nombre(self, pNombre):
        self._nombre = pNombre
    
    Nombre = property(get_Nombre, set_Nombre)
    
    def get_Edad(self):
        return self._edad
    
    def set_Edad(self, pEdad):
        self._edad = pEdad
    
    Edad = property(get_Edad, set_Edad)
    
    def imprimePersona(self):
        print(f"Nombre: {self.get_Nombre()}, Edad: {self.get_Edad()}")
        
    def es_Mayor_Edad(self):
        if (self.get_Edad()  >= 18):
            return True
    
    def es_Mayor_Que(self, pPersona):
        if(self.get_Edad() > pPersona.get_Edad()):
            print(f"{self.Nombre} es mayor que {pPersona.Nombre}")
    
    def get_Mayor(pPersona1, pPersona2):
        if(pPersona1.get_Edad() > pPersona2.get_Edad()):
            return pPersona1
        else:
            return pPersona2
        

persona1=Persona()
persona1.Nombre="Gianluca"
persona1.Edad=25
persona1.imprimePersona()

persona2=Persona()
persona2.Nombre="Carlos"
persona2.Edad=40
persona2.imprimePersona()

persona1 = Persona("Gianluca", 25)
persona1.es_Mayor_Edad()

persona2 = Persona("Carlos", 20)

persona1.es_Mayor_Que(persona2)


personaMayor = Persona.get_Mayor(persona1,persona2)
'''

#Ejercicio 6
'''
class Alumno:
    _nombre = None
    _nota = None
    
    def __init__(self, nombre=None, nota=None):
        self._nombre = nombre
        self._nota = nota
    
    def get_Nombre(self):
        return self._nombre
    
    def set_Nombre(self, pNombre):
        self._nombre = pNombre
    
    Nombre = property(get_Nombre, set_Nombre)
    
    def get_Nota(self):
        return self._nota

    def set_Nota(self):
        return self._nota
    
    Nota = property(get_Nota, set_Nota)
    
    def mostrar_Notas(self):
        if(self.get_Nota() >= 4):
            print("Aprobado")
        else:
            print("Desaprobado")
        

alumno1 = Alumno("Gianluca", 4)
alumno1.mostrar_Notas()
'''

#Ejercicio 7
'''
class Persona:
    _nombre = None
    _edad = None
    
    def __init__(self, nombre=None, edad=None):
        self._nombre = nombre
        self._edad = edad
    
    def get_Nombre(self):
        return self._nombre
    
    def set_Nombre(self, pNombre):
        self._nombre = pNombre
    
    Nombre = property(get_Nombre, set_Nombre)
    
    def get_Edad(self):
        return self._edad
    
    def set_Edad(self, pEdad):
        self._edad = pEdad
    
    Edad = property(get_Edad, set_Edad)
    
    def imprimePersona(self):
        print(f"Nombre: {self.get_Nombre()}, Edad: {self.get_Edad()}")


class Cuenta:
    
    def __init__(self, titular=None, cantidad=0):
        self._titular = titular
        self._cantidad = cantidad
    
    def get_Titular(self):
        return self._titular
    
    def set_Titular(self, titular):
        self._titular = titular
    
    Titular = property(get_Titular, set_Titular)
    
    def get_Cantidad(self):
        return self._cantidad
    
    def set_Cantidad(self, cantidad):
        self._cantidad = cantidad
    
    Cantidad = property(get_Cantidad, set_Cantidad)
    
    def mostrar(self):
        print(f"Titular: {self.get_Titular().get_Nombre()}, Cantidad: {self.get_Cantidad()}")

class CuentaJoven(Cuenta):
    
    def __init__(self, titular=None, cantidad=0):
        super().__init__(titular, cantidad)
    
    def es_Titular_Valido(self):
        return self.get_Titular().esTitularValido()
    
    def retirar(self, cantidad):
        if self.get_Titular().get_Edad() >= 18:
            if cantidad <= self.get_Cantidad():
                self.set_Cantidad(self.get_Cantidad() - cantidad)
                return True
            else:
                print("Saldo insuficiente.")
                return False
        else:
            print("Titular no autorizado para retirar dinero.")
            return False
        
    def mostrar(self):
        print(f"Cuenta Joven. Titular: {self.get_Titular().get_Nombre()}, Cantidad: {self.get_Cantidad()}, Bonificación: {self.get_Titular().get_Bonificacion()}")
        

class Titular(Persona):
    _bonificacion = None
    
    def __init__(self, nombre=None, edad=None, bonificacion=0):
        super().__init__(nombre, edad)
        self._bonificacion = bonificacion
        
    def get_Bonificacion(self):
        return self._bonificacion
    
    def set_Bonificacion(self, value):
        self._bonificacion = value
        
    Bonificacion = property(get_Bonificacion, set_Bonificacion)
    
    def esTitularValido(self):
        if(self.get_Edad > 16 and self.get_Edad < 25):
            return True
    
    def imprimeTitular(self):
        super().imprimePersona()
        print(f"Bonificación: {self.get_Bonificacion()}")

titular1 = Titular("Gianluca", 25, 10)
cuentaJoven1 = CuentaJoven(titular1,1000)
cuentaJoven1.mostrar()

titular2 = Titular("Pablo", 15, 10)
cuentaJoven2 = CuentaJoven(titular2,200)
cuentaJoven2.mostrar()
'''

#Ejercicio 8
'''
class Estadisticas:
    _archivo = None
    
    def __init__(self, archivo):
        self._archivo = archivo
    
    def get_Archivo(self):
        return self._archivo
    
    def set_Archivo(self, pArchivo):
        self._archivo = pArchivo
    
    Archivo = property(get_Archivo, set_Archivo)
    
    def agregar_Archivo(self, pArchivo):
        self.Archivo = pArchivo
        
    def mostrar(self):
        if self.Archivo:
            try:
                with open(self.archivo, 'r') as archivo:
                    datos = archivo.readlines()
                    for linea in datos:
                        print(linea.strip())
            except FileNotFoundError:
                print(f"El archivo '{self.Archivo}' no se encuentra.")
            except Exception as err:
                print(f"Ocurrió un error al leer el archivo: {err}")
        else:
            print("No se ha especificado ningún archivo.")


estadistica = Estadisticas("data.txt")
estadistica.mostrar()
'''

#Ejercicio 9
'''
class Sensor:
    _numeroSensor = None
    
    def __init__(self, pNroSensor):
        self._numeroSensor = pNroSensor
    
    
    def get_Value(self):
        return 0
    
    NroSensor= property(get_Value, None)
    def rad_int(self):
        return random.randint(-100, 100)

class SensorTemperatura(Sensor):
    def __init__(self, pNroSensor):
        super().__init__(pNroSensor)
    
    def get_Value(self):
        valor = float(self.rad_int())
        return max(0, valor) 

class SensorHumedad(Sensor):
    def __init__(self, pNroSensor):
        super().__init__(pNroSensor)
    
    def get_Value(self):
        valor = self.rad_int()
        return valor / 10

sensor_base = Sensor(1)
print(f"Sensor base (Número {sensor_base.NroSensor}): {sensor_base.get_Value()}")

sensor_temp = SensorTemperatura(2)
print(f"Sensor de temperatura (Número {sensor_temp.NroSensor}): {sensor_temp.get_Value()}")

sensor_hum = SensorHumedad(3)
print(f"Sensor de humedad (Número {sensor_hum.NroSensor}): {sensor_hum.get_Value()}")
'''

#Ejercicio 10
'''
class Tarjeta:
    pass

class Tarjeta_Descuento(Tarjeta):
    pass
'''
#Ejercicio 11
class Contacto:
    def __init__(self, nombre, telefono):
        self.nombre = nombre
        self.telefono = telefono

class Agenda:
    def __init__(self):
        self.contactos = []

    def agregar_contacto(self, contacto):
        self.contactos.append(contacto)
        print("Contacto añadido correctamente.")

    def listar_contactos(self):
        if self.contactos:
            print("Lista de contactos:")
            for contacto in self.contactos:
                print(f"Nombre: {contacto.nombre}, Teléfono: {contacto.telefono}")
        else:
            print("La agenda está vacía.")

    def buscar_contacto(self, nombre):
        for contacto in self.contactos:
            if contacto.nombre.lower() == nombre.lower():
                print(f"Nombre: {contacto.nombre}, Teléfono: {contacto.telefono}")
                return
        print("Contacto no encontrado.")

# Función para mostrar el menú y manejar las opciones
def menu():
    print("\nMenú:")
    print("a. Añadir contacto")
    print("b. Listar contactos")
    print("c. Buscar un contacto")
    print("q. Salir")

    opcion = input("Seleccione una opción: ").lower()
    return opcion

# Función principal del programa
def main():
    agenda = Agenda()

    while True:
        opcion = menu()

        if opcion == 'a':
            nombre = input("Ingrese el nombre del contacto: ")
            telefono = input("Ingrese el número de teléfono del contacto: ")
            contacto = Contacto(nombre, telefono)
            agenda.agregar_contacto(contacto)
        elif opcion == 'b':
            agenda.listar_contactos()
        elif opcion == 'c':
            nombre = input("Ingrese el nombre del contacto a buscar: ")
            agenda.buscar_contacto(nombre)
        elif opcion == 'q':
            print("Adiós!")
            break
        else:
            print("Opción no válida.")

if __name__ == "__main__":
    main()

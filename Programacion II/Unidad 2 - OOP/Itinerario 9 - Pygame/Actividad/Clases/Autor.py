class Autor:
    
    def __init__(self, nombre, apellido, nacionalidad, fechaNacimiento):
        self.nombre = nombre
        self.apellido = apellido
        self.nacionalidad = nacionalidad
        self.fechaNacimiento = fechaNacimiento
        
    def mostrarInformacion(self):
        print(f"Nombre y apellido: {self.apellido} {self.nombre}, Nacionalidad: {self.nacionalidad}, Fecha de Nacimiento: {self.fechaNacimiento}")
        
    
    def __str__(self):
        return f"{self.nombre} {self.apellido}"
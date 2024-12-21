class Libro:
    
    def __init__(self, titulo, autor, año, genero, isbn):
        self.titulo = titulo
        self.autor = autor
        self.año = año
        self.genero = genero
        self.isbn = isbn
    
    def mostrarInformacion(self):
        print(f"Título: {self.titulo}, Autor: {self.autor}, Año: {self.año}, Género: {self.genero}, ISBN: {self.isbn}")
        
        

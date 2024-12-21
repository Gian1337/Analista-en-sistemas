class Biblioteca:
    
    def __init__(self):
        self.listaLibros = []
        

    def agregarLibro(self, libro):
        self.listaLibros.append(libro)
        print(f"Libro agregado: {libro.titulo}, ISBN: {libro.isbn}")
    
    def eliminarLibro(self, isbn):
        
        for libro in self.listaLibros:
            if libro.isbn == isbn:
                self.listaLibros.remove(libro)
                print(f"Libro eliminado: {libro.titulo}, ISBN: {libro.isbn}")
        
    def buscarLibroporTitulo(self, titulo):
        
        for libro in self.listaLibros:
            if libro.titulo == titulo:
                return libro
    
    
    def mostrarLibros(self):
        if not self.listaLibros:
            print("No hay libros en la biblioteca.")
        else:
            print("Lista de libros:")
            for libro in self.listaLibros:
                libro.mostrarInformacion()
        
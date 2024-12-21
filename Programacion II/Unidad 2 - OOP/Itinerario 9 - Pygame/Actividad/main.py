import Clases.Autor as Autor
import Clases.Biblioteca as Biblioteca
import Clases.Libro as Libro
from Clases.Biblioteca import *

def menuBiblioteca():  
    print("\nOpciones de la biblioteca:")
    print("1. Agregar libro")
    print("2. Eliminar libro")
    print("3. Buscar libro por título")
    print("4. Mostrar todos los libros")
    print("5. Salir")
            
    opcion = input("Seleccione una opción: ").lower()
            
    return opcion
            

def main():
    
    # Creacion de la biblioteca
    biblioteca = Biblioteca()

    print("Bienvenido a la biblioteca digital")
    
    while True:
        opcion = menuBiblioteca()
        
        if opcion == "1":
            titulo = input("Ingrese el titulo del libro:")
            autor = input("Ingrese el autor del libro")
            año = input("Ingrese el año: ")
            genero = input("Ingrese el género: ")
            isbn = input("Ingrese el ISBN: ")
            
            libro = Libro.Libro(titulo,autor,año,genero,isbn)
            biblioteca.agregarLibro(libro)
        
        if opcion == "2":
            isbn = input("Ingrese el ISBN del libro a eliminar: ")
            biblioteca.eliminarLibro(isbn)
            
        if opcion == "3":
            titulo = input("Ingrese el titulo del libro a buscar: ")
            biblioteca.buscarLibroporTitulo(titulo)
        
        if opcion == "4":
            biblioteca.mostrarLibros()
        
        if opcion == "5":
            print("Abandonando...")
            break
        else:
            print("Opción no válida")
    

    
    

if __name__ == "__main__":
    main()
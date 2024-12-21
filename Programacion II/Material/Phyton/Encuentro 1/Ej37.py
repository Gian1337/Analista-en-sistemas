#37- Dado un número real con 7 decimales, mostrar el mismo valor con un print recortado solo en los primeros 3 decimales.
numero_real = float(input("Ingrese un numero real con más de 3 decimales: "))
print("{:.3f}".format(numero_real))
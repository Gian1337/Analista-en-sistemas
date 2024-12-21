#include <stdio.h>
#include <iostream>
#include <stdlib.h>

int main (){

    int sueldo = 0;
    int suma = 0;
    int cont = 0;
    float promedio = 0;

    printf("Ingrese un numero: %d", cont);
    scanf("%i", &sueldo);

    while (sueldo >= 0)
    {
        suma = suma + sueldo;
        cont++;

        printf("Ingrese un numero:", cont);
        scanf("%d", &sueldo);

        
        
        
    }
    

promedio = suma/cont;


printf("El promedio es: %f", promedio);



system("pause");
    return 0;
}
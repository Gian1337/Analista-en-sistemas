#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <math.h>



int main(){

int valores[5];
int i=0;
int suma = 0;
int longitud = sizeof valores / sizeof valores[0];
int producto = 1;
int pares = 0; 
int impares = 0;

//Carga del vector
for (i = 0; i < 5; i++)
{
    printf("Ingrese un valor: ");
    scanf("%d", &valores[i]);
    
    //Suma de los elementos
    int numeroActual = valores[i];
    suma= suma + numeroActual;
    
    //Producto de los elementos
    producto = producto * numeroActual;

    //Cuenta de pares e impares
    if (numeroActual %2 == 0)
    {
        pares++;
    }else
    {
        impares++;
    }
    
    

}
//Imprime la suma
printf("El total de todos los valores es: %d \n", suma);

//Imprime el producto    
printf("El producto de todos los valores es: %d \n", producto);

//Imprime pares e impares
printf("Pares: %d \n", pares);
printf("Impares: %d \n", impares);



    return 0;
}
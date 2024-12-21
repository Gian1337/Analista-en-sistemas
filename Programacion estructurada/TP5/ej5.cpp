#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <math.h>

//SOLUCION CON CICLO FOR = 11 lineas

int main(){

    int numeros[10]={0,0,0,0,0,0,0,0,0,0};
    int i = 0;
    int suma = 0;

   for (i = 0; i < 10; i++)
   {    
       printf("Escriba un numero: ");
       scanf("%d",&numeros[i]);

       int numeroActual = numeros[i];
       suma= suma + numeroActual;
   }
   printf("La suma de todos los numeros es: %d", suma);

    return 0;
}

#include <stdio.h>
#include <iostream>
#include <stdlib.h>

int main (){

    int factura = 0;
    int suma = 0;
    int cont_1000 = 0;
    int cont_10000= 0;
    int cont_47 = 0;
   
    
    printf("Ingresar el monto de la factura:");
    scanf("%d", &factura);
    
    //printf("El total es: %d", factura);

    while (factura != 0)
    {
        suma = suma + factura;
        //printf("El total es: %d", suma);

         printf("Ingresar el monto de la factura:");
         scanf("%d", &factura);
         
         if (factura >= 1000)
         {
             cont_1000++;
         }
         if (factura >= 10000)
         {
             cont_10000++;
         }
         if (factura >=400 && factura <= 700)
         {
             cont_47++;
         }
         
         
    }
    
    printf("El total es: %d \n", suma);
    printf("La cantidad de facturas mayores a 1000 son: %d \n", cont_1000);
    printf("La cantidad de facturas mayores a 10000 son: %d \n", cont_10000);
    printf("La cantidad de facturas entre 400 y 700 son: %d \n", cont_47);
    system("pause");
    return 0;
}
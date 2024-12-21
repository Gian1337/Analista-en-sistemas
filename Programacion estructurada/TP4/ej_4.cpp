#include <stdio.h>
#include <iostream>
#include <stdlib.h>



int main(){

int factura = 1;
float monto, precio_u;
int cantidad_v, articulo;



printf("Ingresar numero de factura: ");
scanf("%d", &factura);

while (factura != 0)
{
    printf("Ingrese el monto de la factura: %d", factura);
    scanf("%d", &monto);

    printf("Ingrese el numero de articulo: %d", factura);
    scanf("%d", &articulo);

    printf("Ingrese la cantidad vendida: %d", factura);
    scanf("%d", &cantidad_v);

    printf("Indique el precio unitario: %d", precio_u);
    scanf("%f", &precio_u);

    printf("Factura %d: $%f . Articulo: %d . Cantidad vendida: %d . Precio unitario: %f \n", factura, monto, articulo, cantidad_v, precio_u);

    printf("Ingresar numero de factura: ");
    scanf("%d", &factura);
}




    return 0;
}
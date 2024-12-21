#include <stdio.h>
#include <conio.h>
#include <iostream>

int main(){

    int valor1, valor2, valor3;

    printf("Ingrese el primer valor");
    scanf("%d",&valor1);

    printf("Ingrese el segundo valor");
    scanf("%d",&valor2);

    if (valor1>valor2)
    {
        valor3= valor1*valor2;
        printf("El producto es %d", valor3);
    }
    else
    {
        if (valor1=valor2)
        {
            printf("Los valores son iguales");
            }
        
    }
    
    
}
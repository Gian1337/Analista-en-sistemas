#include <stdio.h>
#include <conio.h>
#include <iostream>

int main(){
    
    int valor;
    printf("Ingrese un valor");
    scanf("%d",&valor);

    if (valor>0)
    {
        printf("El valor es positivo");
    }
    else
    {
        if (valor<0)
        {
            printf("El valor es negativo");
        }
        
        else{
            printf("El valor es 0");
        }
    }
    
}
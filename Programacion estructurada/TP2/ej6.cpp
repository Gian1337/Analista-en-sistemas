#include <stdio.h>
#include <conio.h>
#include <iostream>

int main(){
    int altura1, edad1;
    int altura2, edad2;

    printf("Ingrese la altura de la persona 1");
    scanf("%d",&altura1);

    printf("Ingrese la edad de la persona 1");
    scanf("%d",&edad1);

    printf("Ingrese la altura de la persona 2");
    scanf("%d",&altura2);

    printf("Ingrese la edad de la persona 2");
    scanf("%d",&edad2);

    if (edad1>edad2)
    {
        printf("La altura de la persona 1 es %d",&altura1);

        if (edad1<edad2)
        {
            printf("La altura de la persona 2 es %d",&altura2);
        }
        else{
            printf("Ambos son iguales");
        }
    }
system("pause");    
}

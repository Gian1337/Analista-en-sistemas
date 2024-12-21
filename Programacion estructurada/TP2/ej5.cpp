#include <stdio.h>
#include <conio.h>
#include <iostream>

int main(){

    int lado1,lado2,lado3;

    printf("Ingrese el primer lado");
    scanf("%d",&lado1);

    printf("Ingrese el segundo lado");
    scanf("%d",&lado2);

    printf("Ingrese el tercer lado");
    scanf("%d",&lado3);

    if (lado1==lado2==lado3)
    {
        printf("Es un triangulo equilatero");
    }
    else if (lado1==lado2 || lado1==lado3 || lado2==lado3)
    {
        printf("Es un triangulo isosceles");
    }
    else{
        printf("Es un triangulo escaleno");
    }
    
    
    
    system("pause");

}
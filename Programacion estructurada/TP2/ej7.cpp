#include <stdio.h>
#include <conio.h>
#include <iostream>

int main(){
    int vh,ht,sueldo;
    //vh= valor hora; ht= horas trabajadas

    printf("Ingrese el valor de la hora");
    scanf("%d",&vh);

    printf("Ingrese la cantidad de horas trabajadas");
    scanf("%d",&ht);

    if (ht>=50 && ht<150)
    {
        sueldo=(vh*ht)+100;
        printf("El sueldo es de %d", sueldo);
    }
    else{
        if (ht>=150)
        {
        sueldo=(vh*ht)+200;
        printf("El sueldo es de %d", sueldo);
        }
        
    }
system("pause");

}
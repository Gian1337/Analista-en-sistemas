#include <stdio.h>
#include <math.h>
#include <iostream>
#include <conio.h>


int main(){

    int num, i, contador1_10,contador10_20, contador20_30,contador30;
    float porcentaje;
    contador1_10 = 0;
    contador10_20 = 0;
    contador20_30 = 0;
    contador30 = 0;

    for ( i = 1; i <=30; i++)
    {
        printf("Ingrese un valor %i: ", i);
        scanf("%i",&num);

        if (num<=10 && num>=1)
        {
            contador1_10++;
            
        }
        else if (num<20 && num>10)
        {
            contador10_20++;
        }
        
        if (num>=20 && num<=30)
        {
            contador20_30++;
        }
        else if (num>30)
        {
            contador30++;        
        }
        
        
        
    }

printf("Los numeros entre 1 y 10 son %i;", contador1_10);
printf("Los numeros entre 10 y 20 son %i;", contador10_20);
printf("Los numeros entre 20 y 30 son %i;", contador20_30);
printf("Los numeros mas de 30 son %i;", contador30);

system("pause");
    return 0;
}
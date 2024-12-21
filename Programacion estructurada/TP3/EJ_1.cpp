#include <stdio.h>
#include <math.h>
#include <iostream>
#include <conio.h>


int main(){

float suma, promedio;
suma=0, promedio=0;
int i,num;
i=0, num=0;


for (i=0; i<=25; i++)
{
    printf("Ingrese un numero:", i);
    scanf("%d",&num);

    suma= suma + num;
    i = i + 1;
}

promedio= (float)suma/25;
printf("El promedio es: %d", promedio);

system("pause");
return 0;
}
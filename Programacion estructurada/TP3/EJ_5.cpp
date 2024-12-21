#include <stdio.h>
#include <math.h>
#include <iostream>
#include <conio.h>

int main(){

//char patente;
float porcentaje40;
int multa,contadormayor,contadormenor, i, total,suma_mayor,suma_menor;
contadormenor = 0;
contadormayor = 0;
total = 0;
multa = 0;
i= 0;
suma_mayor = 0;
suma_menor = 0;
porcentaje40=0;

for ( i = 1; i <=50 ; i++)
{
    printf("Ingrese la  multa %i", i);
    scanf("%i", &multa);

    if (multa>40)
    {
        suma_mayor= suma_mayor + multa;
        contadormayor++;
    }
    else
    {
        suma_menor = suma_menor + multa;
        contadormenor++;
    }
    
    
    
}
total = suma_mayor+suma_menor;
printf("El total cobrado es %i: ", total);

porcentaje40= (contadormayor*total)/100;
printf("El porcentaje de los que superan los $40 es: %f", porcentaje40);

printf("La cantidad de montos que superan los $40 son: %i", contadormayor);

system("pause");
return 0;
}
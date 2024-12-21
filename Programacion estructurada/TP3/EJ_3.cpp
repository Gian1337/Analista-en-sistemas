#include <stdio.h>
#include <math.h>
#include <iostream>
#include <conio.h>

int main(){

    int num,i,suma_par,suma_impar,cuenta_par,cuenta_impar,c15,promedio,promedio_par,promedio_impar;
    suma_par = 0;
    suma_impar = 0;
    cuenta_par = 0;
    cuenta_impar = 0;
    c15 = 0;

    for (i = 1; i <= 8; i++)
    {
        printf("Ingrese un valor %i: ",i);
        scanf("%i",&num);
        if (fmod(num,2)==0)
        { 
            suma_par = suma_par + num;
            cuenta_par++;
        }
        else
        {
            suma_impar= suma_impar + num;
            cuenta_impar++;
        }
        if (num>15)
        {
            c15++;
        }
        
        
        
    }
    
    promedio = (suma_par+suma_impar)/8;
    printf("El promedio es %i: ", promedio);

    promedio_par = suma_par/cuenta_par;
    printf("El promedio de pares es %i: ", promedio_par);

    promedio_impar= suma_impar/cuenta_impar;
    printf("El promedio de impares es %i: ", promedio_impar);

    printf("Los numeros que superan al 15 son %i: ", c15);





    return 0;
}
#include <stdio.h>
#include <iostream>
#include <stdlib.h>

int main(){

int valor = 0;
int cont = 0;
float promedio_p = 0;
float promedio_n= 0;
int suma = 0;
int ceros = 0;
int negativos = 0;
int positivos = 0;

printf("Ingresar un valor:");
scanf("%d", &valor);

while (valor != 0)
{
    suma = suma + valor;
    cont++;

    printf("Ingresar un valor:");
    scanf("%d", &valor);

    if (valor == 0)
    {
        ceros++;
    }
    if (valor < 0)
    {
        negativos++;
    }
      else
    {
        positivos++;
    }
    
    
    
    
}

promedio_p=(suma/positivos)*100;
printf("Promedio positivos es: %f", promedio_p);

promedio_n=(suma/negativos)*100;
printf("Promedio negativos es: %f", promedio_n);
//printf("El total es: %d \n", suma);
//printf("cantidad negativos: %d \n", negativos);
//printf("cantidad positivos: %d \n", positivos);
printf("cantidad ceros: %d \n", ceros);



system("pause");
return 0;
}
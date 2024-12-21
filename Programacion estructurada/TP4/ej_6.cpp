#include <stdio.h>
#include <iostream>
#include <stdlib.h>

int main(){

int n_auto = 0;
float tiempo = 0;
int cont = 1;
int primero = 0;
int ultimo = 0;

printf ("Ingrese el numero del auto %d:", cont);
scanf("%d",&n_auto);

printf("Ingrese el tiempo:");
scanf("%f", &tiempo);

while (n_auto != 0)
{
    if (cont==1)
    {
        primero = n_auto;
        ultimo = n_auto;
    }
    else
    {
        if (n_auto>primero)
        {
            primero = n_auto;
        }
        if (n_auto<ultimo)
        {
            ultimo = n_auto;
        }
            
    }
    
    cont++;
    printf ("Ingrese el numero del auto %d:", cont);
    scanf("%d",&n_auto);

    printf("Ingrese el tiempo:");
    scanf("%f", &tiempo);
    
}


printf("El primer auto es el %d \n", primero);
printf("El ultimo auto es el %d \n", ultimo);

return 0;
}
#include <stdio.h>
#include <math.h>
#include <iostream>
#include <conio.h>


int main(){
 
 int num, ceros, positivos, negativos, i;
    positivos = 0;
    negativos = 0;
    ceros = 0;
    i = 0;

    for ( i = 0; i <=10; i++)
    {
        printf("Escriba un numero");
        scanf ("%d",&num);  

        if (num == 0)
        {
            ceros= ceros + 1;
            
        }
        else
        {
            if (num < 0)
            {
                negativos = negativos + 1;
                
            }
            else
            {
                positivos = positivos + 1;
                
            }
            
            
        }
        
        
    }
    
    printf("Los ceros son: %d", ceros);
    printf("Los positivos son: %d", positivos);
    printf("Los negativos son: %d", negativos);

    return 0;
}
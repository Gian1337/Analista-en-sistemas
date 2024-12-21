#include <stdio.h>
#include <iostream>
#include <stdlib.h>

int main(){
 float temperatura = 0;
 float max = 0;
 float min = 0;
 int cont = 1;
 float total = 0;
 
 printf("Ingrese una temperatura: %d", cont);
 scanf("%f", &temperatura);

 while (temperatura <= 1000)
 {
     if (cont == 1)
     {
         max = temperatura;
         min = temperatura;
     }
     else
     {
         if (temperatura>max)
         {
             max = temperatura;
         }
         if (temperatura<min)
         {
             min = temperatura;
         }
         
     }
     
     cont++;
     //total = total + temperatura;
     
     printf("Ingrese una temperatura: %d", cont);
     scanf("%f", &temperatura);
     
 }
 

printf("La mayor temperatura es: %f", max);
printf("La menor temperatura es: %f", min);

    return 0;
}
#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <math.h>


int main(){

    //Valor hora semana
    int valor_hora= 50;
    //Valor hora fin de semana
    int valor_hora2=50 + ((30*50)/100); // = 65
    float cantidad_horas = 0;
    float monto_total = 0; //Monto por dias de semana
    //float monto_total2 = 0;//Monto por fines de semana
    int opcion = 0;

    printf("Ingrese el tipo de modalidad: \n1-Semanal \n2-Fin de semana \n3-Salir");
    scanf("%d",&opcion);

    

    while (opcion != 3)
    {
        if (opcion == 3)
        {
            printf("Ha salido del programa");
            break;
        }
        
        printf("Ingrese la cantidad de horas deseadas:");
        scanf("%f",&cantidad_horas);

        if (opcion == 1)
        {
            monto_total = valor_hora * cantidad_horas;
            printf("El monto a pagar es: %f", monto_total);
            printf("\nLa cantidad de horas contratadas son: %f", cantidad_horas*2);
            
        }
    
        if (opcion == 2)
        {
            monto_total= valor_hora2 * cantidad_horas;
            printf("El monto a pagar es: %f", monto_total);
            printf("\nLa cantidad de horas contratadas son: %f", cantidad_horas*2);
        }
        
        printf("\nIngrese el tipo de modalidad: \n1-Semanal \n2-Fin de semana \n3-Salir");
        scanf("%d",&opcion);
        
    }
   

    system("pause");
    return 0;
}
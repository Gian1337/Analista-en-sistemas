#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

int main()
{
    int vc = 0;
    int cc = 0;
    
    printf  ("Ingrese el valor del credito a pedir: " );
    scanf ("%d",&vc);
    printf("Ingrese la cantidad de cuotas deseada: " );
    scanf("%d",&cc);
    float vcu = vc/cc;
    printf("El total de cada cuota es: %d",&vcu);
    system("pause");
}

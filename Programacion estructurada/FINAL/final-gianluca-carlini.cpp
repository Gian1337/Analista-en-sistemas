#include <iostream>
#include <conio.h>
#include <stdio.h>

using namespace std;

int main()
{
    string nombres[5];
    int edades[5];
    int i = 0,j,aux;
    int suma = 0;
    float promedio = 0;
    int mayor = 0;
    

    for (int i = 0; i < 4; i++)
    {
            cout<<"Ingrese un nombre: "<<endl; cin>> nombres[i];
            cout<<"Ingrese la edad: "<<endl, cin>>edades[i];

            suma=+ edades[i];

            if (edades[i]>mayor)
            {
                mayor = edades[i];
            }
            
    }

    
    
    cout<<"El promedio es: "<< suma/4 <<" ";
    cout<<"El mayor tiene: "<< mayor<<" ";

for (i = 0; i < 4; i++)
{
    for ( j = 0; j < 4; j++)
    {
        if (edades[j]>edades[j+1]) // Numero actual > numero siguiente
        {
            aux = edades[j];
            edades[j] = edades[j+1];
            edades[j+1] = aux; 
        }
        
    }
    
}

cout<<"Orden Descendente: ";
 for ( i = 4; i > 0; i--)
 {
    cout<<nombres[i]<<" ";
    cout<<edades[i]<< " ";
 }

   
    


    getch();
    return 0;
}

//PREGUNTA 1 
    //La indireccion es una técnica de programación en la cual se basa en hacer referencia indirecta a los datos usando las direccions de memoria que los contienen.
    //Se representa: Tipo * puntero_de_tipo; Ejemplo: int * p;

//PREGUNTA 2
    //Un arreglo bidimensional son tablas de valores en la que cada elemento de un arreglo bidimensional está simultaneamente en una fila y columna. Se los suele llamar matrices.

//PREGUNTA 3
    //El indice mínimo y máximo de un array de 512 elementos es 0 y 511, respectivamente.

//PREGUNTA 4
    //La diferencia que existe entre un compilador y un interprete son:
        //Un intérprete traduce instrucciones de alto nivel en una forma intermedia para ser ejecutado. En contraste, un compilador, traduce instrucciones de alto nivel directamente en lenguaje de máquina.
        //El intérprete traduce un programa línea a línea mientras que el compilador traduce el programa entero y luego lo ejecuta
        //El intérprete detecta si el programa tiene errores y permite su depuración durante el proceso de ejecución, mientras que el compilador espera hasta terminar la compilación de todo el programa para generar un informe de errores.

//PREGUNTA 5
        //Una función es un bloque de código que realiza alguna operación. Una función puede definir opcionalmente parámetros de entrada que permiten a los llamadores pasar argumentos a la función
        //Un procedimiento o subrutina es un subalgoritmo que recibiendo o no datos permite devolver varios resultados, un resultado o ninguno. 

#include <iostream>
#include <conio.h>
#include <stdio.h>

using namespace std;

int main()
{

    int matriz[10][10];
    int suma = 0;
    float media;
    int f, c, moda;
    int contador = 0;
    // CARGO LA MATRIZ
    cout << "Matriz en forma desordenada: \n";

    for (int f = 0; f < 10; f++) // FILAS
    {
        for (int c = 0; c < 10; c++) // COLUMNAS
        {
            matriz[f][c] = rand() % 10;
            cout << matriz[f][c] << " ";
            suma += matriz[f][c]; // OBTENGO LA SUMA DE TODA LA MATRIZ
        }
        cout << endl;
    }

    cout << "------------------------" << endl;

    int x;

    for (int i = 0; i < 10; i++) // filas
    {
        for (int n = 0; n < 10; n++) // columnas
        {
            for (int fila1 = i; fila1 < 10; fila1++)
            {
                int aux = 0; // Columna auxiliar

                if (i == fila1)
                {
                    aux = n + 1;
                }

                for (int col1 = aux; col1 < 10; col1++)
                {
                    if (matriz[i][n] > matriz[fila1][col1]) // Ordenamiento
                    {
                        x = matriz[fila1][col1];
                        matriz[fila1][col1] = matriz[i][n];
                        matriz[i][n] = x;
                    }
                }
            }
        }
    }

    // MOSTRAR MATRIZ ORDENADA ASCENDENTE
    int mediana;
    cout << "Matriz en forma ascendente y ordenada: \n";
    for (int f = 0; f < 10; f++) // FILAS
    {
        for (int c = 0; c < 10; c++) // COLUMNAS
        {
            cout << matriz[f][c] << " ";

            //------- MEDIANA -------------
            if (matriz[f][c] % 2 != 0)
            {
                mediana = matriz[f][c] / 2; // IMPAR
            }
            else
            {
                mediana = matriz[f][c] / 2 + (matriz[f][c] / 2 - 1) / 2; // PAR
            }

            //--------MODA------------

            int cont1 = 0, cont2 = 0;

            for (int f = 0; f < 10; f++) // 0
            {
                for (int c = 0; c < 10; c++) // 0
                {

                    if (matriz[f] == matriz[c] && f != c)
                    {
                        cont1++;
                    }
                }
                if (cont1 > cont2)
                {
                    cont2 = cont1;
                    moda = matriz[f][c];
                }

                cont1 = 0;
            }
        }
        cout << endl;
    }

    cout << "\nLa mediana es: " << mediana;
    //-----------PROMEDIO ------------

    media = float(suma / 100);
    cout << "\nLa media es: " << media << endl;
    //------------------------ MODA -----------------------------
    cout<<"La moda es: "<< moda;
    system("pause");
    

    getch();
    return 0;
}
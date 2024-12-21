#include <iostream>
#include <conio.h>

using namespace std;
int particion(int array[], int inicio, int fin) // particion
{
    int pivot = array[fin]; // Pivot mas a la derecha
    int pIndex = inicio; //elementos menores = a la izquierda de Pindex // elementos mayores= a la derecha de Pindex
    for (int i = inicio; i < fin; i++)
    {                                   // cada vez que encontramos un elemento menor o igual que el pivote, `pIndex`
                                          // se incrementa, y ese elemento se colocaría antes del pivote.
        if (array[i] <= pivot) 
        {
            swap(array[i], array[pIndex]);
            pIndex++;
        }
    }
    swap(array[pIndex], array[fin]);
    return pIndex;
}


void quicksort (int array[], int inicio, int fin){ //clasificacion rapida
    if (inicio >= fin) //condicion base
    {
        return;
    }

    int pivot = particion(array,inicio,fin); //reorganizo elementos desde el pivot
    quicksort(array,inicio, pivot - 1);
    quicksort(array, pivot + 1, fin);
    
}



int main()
{
    int array[] = {2, 5, 1, 3, 4, 6, 9, 8, 7, 10, 12, 13, 11, 18, 20, 19, 17, 16, 14, 15};

    int i, j, aux, tipo_ord;
    int inicio, fin;

    printf("Tipo de ordenamiento: 1- Bubblesort 2-QuickSort: ");
    scanf("%d", &tipo_ord);

    if (tipo_ord == 1) // BUBBLESORT
    {
        for (i = 0; i < 20; i++)
        {
            for (j = 0; j < 20; j++)
            {
                if (array[j] > array[j + 1]) // Numero actual > numero siguiente
                {
                    aux = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = aux;
                }
            }
        }

        cout << "Orden Ascendente: ";
        for (i = 0; i < 20; i++)
        {
            cout << array[i] << " ";
        }
    }
    else // QUICKSORT
    {
        int n = sizeof(array) / sizeof(array[0]);
        quicksort(array, 0, n-1);

        for (int i = 0; i < n; i++) //array ordenado
        {
            cout<<array[i]<< " ";
        }
        
    }

    getch();
    return 0;
}
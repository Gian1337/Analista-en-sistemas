#include <iostream>
#include <conio.h>

using namespace std;

int main(){
    int array[] = {2,5,1,3,4,6,9,8,7,10,12,13,11,18,20,19,17,16,14,15};

    int i,j,aux;

for (i = 0; i < 20; i++)
{
    for ( j = 0; j< 20; j++)
    {
        if (array[j] > array[j+1])
        {
            aux = array[j];
            array[j] = array[j+1];
            array[j+1] = aux;
        }
        
    }
    
}

cout<<"Orden Ascendente: ";
for ( i = 0; i < 20; i++)
{
    cout<<array[i]<< " ";
}

cout<< "Orden Descendente: ";
for ( i = 19; i >= 0; i--)
{
    cout<<array[i]<< " ";
}







    getch ();
    return 0;
}
#include <iostream>
#include <conio.h>

using namespace std;


int main(){

    int array[10]; //Array de 10 posiciones
    int n;


    cout<<"Digite cantidad elementos que va tener el array: ";
    cin>>n;

    for (int i = 0; i < n; i++)
    {
        cout<<"Escriba un numero: ";
        cin>>array[i]; //Guardo los elementos en array
    }


    //Indices

    for ( int i = 0; i < n; i++)
    {
        cout<<i<<" -> "<< array[i]<<endl;
    }
    


        











    getch ();
    return 0;
}
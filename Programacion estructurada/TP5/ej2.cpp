#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <math.h>


#include <iostream>

using namespace std;

int main(){

int numeros[10] = {0,0,0,0,0,0,0,0,0,0};

for( int i = 0; i < 10; i++){
cout<<"Escriba un numero: "<<endl; cin>>numeros[i];
}

cout<<"Mostrando numeros: ";

for( int i = 0; i < 10; i++){
cout<<numeros[i]<<" ";
}

cout<<endl;

cin.get();

return 0;
}
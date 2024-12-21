#include <stdio.h>
 
int main() {
    int matriz[3][3] = {{100, 74, 99}, {11, 36, 68}, {23, 9, 81}};
    int suma;
    int i, j;
 
    suma = 0;
 
    for ( i = 0; i < 3; i++ )
        for ( j = 0; j < 3; j++ )
            suma = suma + matriz[i][j];
    printf ( "%d\n", suma );
 
    return 0;
}
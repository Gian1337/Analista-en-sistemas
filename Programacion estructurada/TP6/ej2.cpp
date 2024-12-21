#include <stdio.h>
#include <math.h>
#include <conio.h>

int main(){
	
	int sueldos[5];
	int edades[5];
	int sumaSueldo;
	int sumaEdades;
	int promedioSueldo;
	int promedioEdades;
	int i=0;
	int cont23a40=0;
	int suma2340 =0;
	int sueldoprom2340 =0;
	int menorProm =0;

	
	
	for(i=0; i<5; i++)
	{
		
		printf("\nIngrese el sueldo del empleado %d: ",i+1);
		scanf("%d", & sueldos[i]);
		
		printf("Ingrese la edad del empleado %d: ",i+1);
		scanf("%d", & edades[i]);
		
		
		
		sumaSueldo= sumaSueldo + sueldos[i];
	
		sumaEdades= sumaEdades + edades[i];
		
			
	}		
	for(int j=0; j<5; j++)
		{
			if(edades[j]>=23 && edades[j]<=40)
			{
			
			cont23a40++;
			
			suma2340= suma2340 + sueldos[j];
					
			}
		}	

   	promedioSueldo = sumaSueldo / 5;
	promedioEdades= sumaEdades/5;
	sueldoprom2340=suma2340/cont23a40;
	
	 for(int k=0; k<5; k++){
		
		if(edades[k]<promedioEdades){
			
			menorProm ++;
		}
	}
		printf("\n El sueldo promedio es: %d \n", promedioSueldo);
		printf("\n La edad promedio es:%d \n", promedioEdades);
		printf("\n Los empleados entre 23 y 40 son %d\n", cont23a40);
		printf("\n El promedio de sueldo de los empleados de 23 a 40 a�os es: %d\n", sueldoprom2340);
		printf("\n El numero de empleados con edad menor a la promedio es: %d", menorProm);
		
	
	return 0;
}


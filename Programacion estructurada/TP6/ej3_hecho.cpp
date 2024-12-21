#include<stdio.h>
#include<iostream>
#include<math.h>

using namespace std;

int main(int argc, char** argv) {
	setlocale(LC_CTYPE, "Spanish");
	string nombres[50];
	int categoria[50], antiguedad[50], sueldos[50];
	int i, cat, ant,cont=0, cont1 = 0, cont2 = 0, cont3 = 0, sueldo1 = 0, sueldo2 = 0, sueldo3 = 0, sueldomax = 0, total = 0;
	string nombre, nombremax;
	float promedio = 0;

	for (i = 0; i < 50; i++) {
		cout << "ingrese el nombre del empleado " << i + 1 << endl;
		cin >> nombre;
		nombres[i] = nombre;
	}
	for (i = 0; i < 50; i++) {
		cout << "Ingrese la categoria (1,2 o 3) del empleado " << nombres[i] << endl;
		cin >> cat;
		categoria[i] = cat;
		cout << "Ingrese los años de antigüedad del empleado" << endl;
		cin >> ant;
		antiguedad[i] = ant;
	}
	for (i = 0; i < 50; i++) {
		if (categoria[i] == 1) {
			cont1++;
			sueldo1 = sueldo1 + 1500 + (100 * antiguedad[i]);
			sueldos[i] = 1500 + (100 * antiguedad[i]);
		}
		else {
			if (categoria[i] == 2) {
				cont2++;
				sueldo2 = sueldo2 + 2000 + (100 * antiguedad[i]);
				sueldos[i] = 2000 + (100 * antiguedad[i]);
			}
			else {
				cont3++;
				sueldo3 = sueldo3 + 2500 + (100 * antiguedad[i]);
				sueldos[i] = 2500 + (100 * antiguedad[i]);
			}
		}
	}
	for (i = 0; i < 50; i++) {
		cont++;
		if (cont == 1) {
			sueldomax = sueldos[i];
			nombremax = nombres[i];
		}
		else {
			if (sueldos[i] > sueldomax) {
				sueldomax = sueldos[i];
				nombremax = nombres[i];
			}
		}
	}
	total = (float)sueldo1 + (float)sueldo2 + (float)sueldo3;
	promedio = total / 50;
	cout << "La cantidad de empleados de categoría 1 es de: " << cont1 << endl;
	cout << "La cantidad de empleados de categoría 2 es de: " << cont2  << endl;
	cout << "La cantidad de empleados de categoría 3 es de: " << cont3 << endl;
	cout << "El total de sueldos pagados a empleados de la categoría 1  es de $" << sueldo1 << endl;
	cout << "El total de sueldos pagados a empleados de la categoría 2  es de $" << sueldo2 << endl;
	cout << "El total de sueldos pagados a empleados de la categoría 3  es de $" << sueldo3 << endl;
	cout << "El sueldo promedio general es de $" << promedio << endl;
	cout << "El sueldo máximo es de $" << sueldomax << " y le corresponde a " << nombremax << endl;
	cout << "El porcentaje del total de sueldo que corresponde a la categoria 1 es de %" << (float)(sueldo1 * 100) / total << endl;
	cout << "El porcentaje del total de sueldo que corresponde a la categoria 2 es de %" << (float)(sueldo2 * 100) / total << endl;
	cout << "El porcentaje del total de sueldo que corresponde a la categoria 3 es de %" << (float)(sueldo3 * 100) / total << endl;


	return 0;
}
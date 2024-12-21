#include <iostream>
 
int main()
{
    int mes;
 
    std::cout << "Mes (1-12): ";
    std::cin >> mes;
 
    switch (mes)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            std::cout << "31 dias" << std::endl;
            break;
 
        case 4:
        case 6:
        case 9:
        case 11:
            std::cout << "30 dias" << std::endl;
            break;
 
        case 2:
            std::cout << "28 dias" << std::endl;
            break;
 
        default:
            std::cout << "Mes no valido" << std::endl;
    }
 
    return 0;
}
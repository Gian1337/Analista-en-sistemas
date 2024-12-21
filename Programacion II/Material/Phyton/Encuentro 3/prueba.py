# 13 
pbi2020 = 21 * 20 + 10 * 10
pbi2021 = 20 * 22 + 9 * 12
pbi2022 = 22 * 21 + 10 * 11

print(f"El PBI de cada año es: (2020)-> {pbi2020} (2021)-> {pbi2021} (2022)-> {pbi2022}")

if pbi2020 > pbi2021 and pbi2020 > pbi2022 :
    print("El PBI del año 2020 es el mayor")
elif pbi2021 > pbi2020 and pbi2021 > pbi2022 :
    print("El PBI del año 2021 es el mayor")
elif pbi2022 > pbi2020 and pbi2022 > pbi2021 :
    print("El PBI del año 2022 es el mayor")
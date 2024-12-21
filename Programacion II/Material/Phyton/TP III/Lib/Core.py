'''Libreria con el funcionamiento principal del programa'''

import pandas as pd
import matplotlib.pyplot as mp
from Lib import Var
import calendar

# Muestra los efectores de monotributo activos por periodo (AÑO)
def mostrarActivos():
    df = pd.read_csv(f'{Var.DATAPATH}\\Data\\monotributo-social-efectores-activos-2022-09-01.csv')
    # Paso la fecha completa del periodo yyyy-mm-dd por solo el año
    df['periodo'] = pd.to_datetime(df['periodo']).dt.year
    
    # Agrupo los datos de todo el dataframe mediante por el periodo
    dfPeriodo = df.groupby('periodo').sum()

    # Creo un grafico de barras para mostrar los datos
    mp.bar(dfPeriodo.index, dfPeriodo['efectores_activos'])
    mp.xlabel('Año')
    mp.ylabel('Activos por millón')
    mp.title('Efectores de monotributo activos por año')
    mp.xticks(dfPeriodo.index, dfPeriodo.index.astype(int))
    mp.get_current_fig_manager().resize(1000, 400)
    mp.get_current_fig_manager().set_window_title('Grafico')
    mp.show()

# Se muestra en porcentajes la cantidad de efectores de cada provincia en un determinado periodo
def mostrarActivosProvincia(periodo : int, filtro : bool):
    df = pd.read_csv(f'{Var.DATAPATH}\\Data\\monotributo-social-efectores-pagos-con-cobertura-obra-social2022-09-01.csv')
    
    # Paso el periodo a un datetime con solo el año y filtro los datos con el periodo que quiero
    df['periodo'] = pd.to_datetime(df['periodo']).dt.year
    dfPeriodo = df[df['periodo'] == periodo]
    if filtro == True:
        dfPeriodo = dfPeriodo[dfPeriodo['provincia'] != 'Buenos Aires']

    # Filtro los datos por cada provincia, sumo sus totales y reseteo los indices
    dfPeriodo = dfPeriodo.groupby(['periodo', 'provincia']).sum().reset_index()
    
    # Elimino dos columnas que no necesito
    dfPeriodo.drop(['provincia_id', 'monto_ms'], axis=1, inplace=True)

    mp.pie(
        x= dfPeriodo['efectores_pagos']
    )
    mp.legend(dfPeriodo['provincia'] ,loc='center right', bbox_to_anchor=(0.1, 0.5), title = 'Provincias')
    mp.get_current_fig_manager().resize(800, 600)
    mp.get_current_fig_manager().set_window_title('Grafico')
    mp.show()

# Muesta el total de activos juntando todas las provincias por cada mes del 2021
def mostrarTotalActivosPeriodo():
    df = pd.read_csv(f'{Var.DATAPATH}\\Data\\monotributo-social-efectores-pagos-con-cobertura-obra-social2022-09-01.csv')
    
    # Pasamos las fechas a el tipo datetime
    df['periodo'] = pd.to_datetime(df['periodo'])

    # Seleccionamos solo las filas del año 2021 (puede ser cualquier año)
    dfPeriodo2021 = df[df['periodo'].dt.year == 2021]
    
    # Pasamos la fechas completas y solo mostramos el mes, agrupando y sumando los efectores totales
    dfPeriodo2021['periodo'] = pd.to_datetime(dfPeriodo2021['periodo']).dt.month
    dfPeriodo2021 = dfPeriodo2021.groupby(['periodo'])['efectores_pagos'].sum().reset_index()
    
    # mediante la libreria calendar pasamos los meses en numero a texto mediante una funcion lambda
    dfPeriodo2021['periodo'] = dfPeriodo2021['periodo'].apply(lambda x: calendar.month_name[x])
    
    # Definimos las propiedades del grafico a mostrar
    mp.plot(dfPeriodo2021['periodo'], dfPeriodo2021['efectores_pagos'])
    mp.xlabel = 'Meses del año'
    mp.ylabel = 'Total efectores pagos'
    mp.title = 'Efectores pagos por mes en el periodo 2021'
    mp.get_current_fig_manager().set_window_title('Grafico')
    mp.get_current_fig_manager().resize(1200, 600)
    mp.show()
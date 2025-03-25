import numpy as np

# Array de días de la semana
dias = np.array(['Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado', 'Domingo'])

# Solicitar la temperatura de cada día al usuario
temperaturas = []
for dia in dias:
    temp = float(input(f'Ingrese la temperatura de {dia} en grados Celsius: '))
    temperaturas.append(temp)

# Convertir la lista a un array de numpy
temperaturas = np.array(temperaturas)

# Calcular máxima, mínima y promedio
temp_max = np.max(temperaturas)
temp_min = np.min(temperaturas)
promedio_temp = np.mean(temperaturas)

# Día con la temperatura más cercana a 25 grados
indice_mas_cercano = np.argmin(np.abs(temperaturas - 25))
dia_mas_cercano = dias[indice_mas_cercano]

# Mostrar resultados
print()
print(f'Temperatura máxima: {temp_max}°C')
print(f'Temperatura mínima: {temp_min}°C')
print(f'Promedio de la semana: {promedio_temp:.2f}°C')
print(f'Día con la temperatura más cercana a 25°C: {dia_mas_cercano} ({temperaturas[indice_mas_cercano]}°C)')

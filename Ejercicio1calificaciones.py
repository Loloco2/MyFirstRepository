import numpy as np

# Array de nombres
nombres = np.array(['Hugo', 'Paco', 'Luis', 'Pulgarcito', 'Pulgarcita'])

# Generar calificaciones aleatorias del 1 al 100
calificaciones = np.random.randint(1, 101, size=len(nombres))

# Asignar calificaciones a cada nombre
for nombre, calificacion in zip(nombres, calificaciones):
    print(f'{nombre}: {calificacion}')

# Calcular máximo, mínimo y promedio
max_calificacion = np.max(calificaciones)
min_calificacion = np.min(calificaciones)
promedio_calificaciones = np.mean(calificaciones)

# Mostrar resultados
print(f'Calificación máxima: {max_calificacion}')
print(f'Calificación mínima: {min_calificacion}')
print(f'Promedio de calificaciones: {promedio_calificaciones:.2f}')

import numpy as np
import matplotlib as plt

numeros = np.arange(1,100)
suma = np.cumsum(numeros)
plt.plot(numeros, suma)
label = "Numeros"
plt.title("Lista de numeros")
plt.xlabel("Numeros")
plt.ylabel("Suma")
plt.legend()
plt.grid
plt.show()


import math

print("Escribe un numero")
num = int(input())

#Saber si el numero es positivo, negativo o 0
def switch(num):
    if num == 0:
        print("Tu numero es 0")
    elif num > 0:
        print("Tu numero es positivo")
    elif num < 0:
        print("Tu numero es negativo")
    else:
        print("Opcion no valida")

print(switch(num))

#Calcular el cuadrado de un numero
cuad = num*num

print("El cuadrado de tu numero es:")
print(cuad)

#Ciclo FOR
print("Dato random, esta es la suma de los numeros hasta el 100")
for i in range (100):
    i+=1
    print (i)

#While
while num > 100:
    wnum = num*num
    print("Su numero multiplicado hasta acercarse al 100 es: "+ wnum )

#Factorial
def factorial(num):
    if num == 0:
        return 1
    else:
        return num*factorial(num-1)
print(f"El factorial de tu numero es {factorial(num)}")
import speech_recognition as sr
import pyttsx3
import time
import sounddevice as sd
import numpy as np

def speak(text):
    engine = pyttsx3.init()
    voices = engine.getProperty('voices')
    for index, voice in enumerate(voices):
        print(f"Índice: {index}, Nombre: {voice.name}, ID: {voice.id}, Lenguaje: {voice.languages}")
    engine.setProperty('voice',voices[3].id)
    engine.say(text)
    engine.runAndWait()

def calculadora():
    while True:
        print("\nCalculadora básica. Opciones: \n1. Suma \n2. Resta \n3. Multiplicación \n4. División \n5. Salir")
        
        opcion = input("Selecciona una opción (1-5): ")
        
        if opcion == '5':
            speak("Gracias por usar la calculadora. ¡Adiós!")
            break
        
        if opcion in ['1', '2', '3', '4']:
            try:
                num1 = float(input("Introduce el primer número: "))
                num2 = float(input("Introduce el segundo número: "))
                
                if opcion == '1':
                    resultado = num1 + num2
                    operacion = "suma"
                elif opcion == '2':
                    resultado = num1 - num2
                    operacion = "resta"
                elif opcion == '3':
                    resultado = num1 * num2
                    operacion = "multiplicación"
                elif opcion == '4':
                    if num2 != 0:
                        resultado = num1 / num2
                        operacion = "división"
                    else:
                        speak("Error: No se puede dividir entre cero.")
                        continue
                
                speak(f"El resultado de la {operacion} es {resultado}")
                print(f"Resultado: {resultado}")
            
            except ValueError:
                speak("Error: Entrada inválida. Por favor, introduce números válidos.")
        else:
            speak("Opción inválida. Por favor, selecciona una opción del 1 al 5.")

calculadora()
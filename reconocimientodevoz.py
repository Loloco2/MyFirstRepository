import speech_recognition as sr
import pyttsx3
import time
import sounddevice as sd
import numpy as np

#Hablar
def speak(text):
    engine = pyttsx3.init()
    voices = engine.getProperty('voices')
    #for index, voice in enumerate(voices):
    #    print(f"Índice: {index}, Nombre: {voice.name}, ID: {voice.id}, Lenguaje: {voice.languages}")
    engine.setProperty('voice',voices[2].id)
    engine.say(text)
    engine.runAndWait()

#Escuchar
def speech_recpgnize():
    recognizer = sr.Recognizer()
    sample_rate = 48000
    duracion = 3

    print ("Escuchando...")
    audioData = sd.rec(int(duracion * sample_rate), samplerate=sample_rate, channels=1, dtype='int16')
    sd.wait()

    audio = sr.AudioData(audioData.tobytes(), sample_rate, 2)

    try:
        return recognizer.recognize_google(audio, language='es-MX').lower()
    
    except sr.UnknownValueError:
        return "No te entendí"
    except sr.RequestError:
        return "Error XD"
    
#Funcion de la alexa
def executeCommand(command):
    if "hora" in command:
        speak("La hora actual es: " + time.strftime("%H:%M"))
    elif "salir" in command:
        speak("Adios, amonos que aqui espantan")
        exit()
    elif "huevos" in command:
        speak("No, no tengo webos, soy una inteligencia artificial")
    else:
        speak("No entendi")
    
speak("Te escucho")
text = speech_recpgnize()
executeCommand(text)
print(text)

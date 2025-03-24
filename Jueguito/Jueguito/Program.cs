using System;

class Program
{
    static void Main(string[] args)
    {
        // Generamos un número aleatorio entre 1 y 100
        Random rnd = new Random();
        int numAleatorio = rnd.Next(1, 50);

        // Mostramos las instrucciones al jugador
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Bienvenido al juego de adivinanza de número.");
        Console.WriteLine("Intenta adivinar el número que he pensado entre 1 y 50.");
        Console.WriteLine("Tienes 5 intentos. ¡Buena suerte!");

        // Configuramos el número máximo de intentos y una variable para contar los intentos
        int MAX_INTENTOS = 5;
        int intentos = 0;

        // Ciclo principal del juego
        while (intentos < MAX_INTENTOS)
        {
            // Pedimos al jugador que ingrese un número
            Console.WriteLine();
            Console.Write("Ingresa tu número: ");
            string input = Console.ReadLine();

            // Intentamos convertir el input del jugador en un número entero
            if (int.TryParse(input, out int numJugador))
            {
                // El input es válido, incrementamos el número de intentos
                intentos++;

                // Comparamos el número del jugador con el número aleatorio
                if (numJugador == numAleatorio)
                {
                    // El jugador ha adivinado el número, salimos del ciclo principal
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine($"¡Felicitaciones! Adivinaste el número en {intentos} intentos.");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine();
                    Console.WriteLine();
                    return;
                }
                else if (numJugador < numAleatorio)
                {
                    // El número del jugador es menor al número aleatorio
                    Console.WriteLine("Tu número es muy bajo. Ingresa un numero más alto.");
                }
                else
                {
                    // El número del jugador es mayor al número aleatorio
                    Console.WriteLine("Tu número es muy alto. Ingresa un numero más bajo.");
                }
            }
            else
            {
                // El input del jugador no es válido
                Console.WriteLine("Por favor, ingresa un número entero válido.");
            }
        }

        // Si llegamos hasta aquí, el jugador ha agotado el número máximo de intentos
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine($"Lo siento, has agotado el número máximo de intentos. El número era {numAleatorio}.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();
        Console.WriteLine();

    }
}
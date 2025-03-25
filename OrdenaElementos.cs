using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entradas = new string[20];
        string[] letras = new string[20];
        string[] numeros = new string[20];
        string[] especiales = new string[20];

        Console.WriteLine("DAME 20 ELEMENTOS O CONQUISTARE CHIAPAS!!!!!:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            string entrada = Console.ReadLine();
            entradas[i] = entrada;
        }

        int letrasI = 0;
        int numerosI = 0;
        int especialesI = 0;
        bool soloEspeciales = true;

        foreach (string entrada in entradas)
        {
            if (char.IsLetter(entrada[0]))
            {
                letras[letrasI] = entrada;
                letrasI++;
                soloEspeciales = false;
            }
            else if (char.IsDigit(entrada[0]))
            {
                numeros[numerosI] = entrada;
                numerosI++;
                soloEspeciales = false;
            }
            else
            {
                especiales[especialesI] = entrada;
                especialesI++;
            }
        }

        if (soloEspeciales)
        {
            Console.WriteLine("Error: Se requiere ingresar otros caracteres además de caracteres especiales.");
        }
        else
        {
            Array.Resize(ref letras, letrasI);
            Array.Resize(ref numeros, numerosI);
            Array.Resize(ref especiales, especialesI);

            Array.Sort(letras);
            Array.Sort(numeros);

            Console.WriteLine("Elementos que empiezan con letra (orden alfabético):");
            foreach (string letra in letras)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("Elementos que empiezan con número (orden ascendente):");
            foreach (string numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Elementos que empiezan con caracter especial:");
            foreach (string especial in especiales)
            {
                Console.WriteLine(especial);
            }
        }

        Console.ReadLine();
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de números (debe ser un número positivo):");
        int n;
        do
        {
            n = LeerEntero();
            if (n <= 0)
                Console.WriteLine("Por favor, ingrese un número positivo.");
        } while (n <= 0);

        int[] numeros = new int[n];
        Console.WriteLine("Ingrese los números uno por uno:");

        for (int i = 0; i < n; i++)
        {
            numeros[i] = LeerEntero();
        }

        Console.WriteLine("\nArreglo original:");
        MostrarArreglo(numeros);

        BubbleSort(numeros);

        Console.WriteLine("\nArreglo ordenado de menor a mayor:");
        MostrarArreglo(numeros);

        Console.ReadLine();
    }

    static int LeerEntero()
    {
        int valor;
        while (true)
        {
            Console.Write(" > ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out valor))
                return valor;
            Console.WriteLine("Entrada inválida. Ingrese un número entero.");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            Console.WriteLine($"\nIteración {i + 1}:");

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
                MostrarArreglo(array);
            }

            if (!swapped)
                break;
        }
    }

    static void MostrarArreglo(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número en notación científica (ejemplo: 2^10):");
        string input = Console.ReadLine();

        try
        {
            string result = ConvertScientificNotation(input);
            Console.WriteLine($"El número completo es: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static string ConvertScientificNotation(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("La entrada no puede estar vacía.");

        Regex regex = new Regex(@"^(\d+)\^(\d+)$");
        Match match = regex.Match(input);

        if (!match.Success)
            throw new FormatException("Formato incorrecto. Use la notación base^exponente (ej: 2^10).");

        int baseNum = int.Parse(match.Groups[1].Value);
        int exponent = int.Parse(match.Groups[2].Value);
        double result = Math.Pow(baseNum, exponent);

        return result.ToString();
    }
}

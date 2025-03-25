using System;
using System.IO;
using System.Text;

namespace TXTFileCoder
{
    class TXTCreator
    {
        static void Main(string[] args)
        {
            string fileName = Path.Combine(Directory.GetCurrentDirectory(), "mensaje_codificado.txt");

            if (!File.Exists(fileName))
            {
                using (FileStream fs = File.Create(fileName))
                {
                    // Solo lo creamos si no existe
                }
            }

            Console.WriteLine("¿Desea codificar o decodificar el archivo? (codificar/decodificar):");
            string choice = Console.ReadLine().ToLower();

            try
            {
                if (choice == "codificar")
                {
                    Console.WriteLine("Ingrese el texto a codificar:");
                    string userText = Console.ReadLine();
                    string encodedText = Encode(userText);
                    File.WriteAllText(fileName, encodedText);
                    Console.WriteLine("Mensaje codificado y guardado exitosamente en " + fileName);
                }
                else if (choice == "decodificar")
                {
                    string encodedText = File.ReadAllText(fileName);
                    string decodedText = Decode(encodedText);
                    Console.WriteLine("Mensaje decodificado:");
                    Console.WriteLine(decodedText);
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }

            Console.ReadLine(); // Evita que la consola se cierre inmediatamente
        }

        static string Encode(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int code = char.ToUpper(c) - 'A';
                    sb.Append(code + " ");
                }
                else
                {
                    sb.Append("#" + c + " "); // Prefijo # para caracteres especiales y números
                }
            }
            return sb.ToString().Trim();
        }

        static string Decode(string encodedText)
        {
            StringBuilder sb = new StringBuilder();
            string[] parts = encodedText.Split(' ');
            foreach (string part in parts)
            {
                if (int.TryParse(part, out int code) && code >= 0 && code <= 25)
                {
                    sb.Append((char)(code + 'A'));
                }
                else if (part.StartsWith("#")) // Identificar caracteres especiales y números
                {
                    sb.Append(part.Substring(1));
                }
                else
                {
                    sb.Append(part);
                }
                sb.Append(" "); // Restaurar los espacios originales
            }
            return sb.ToString().Trim();
        }
    }
}

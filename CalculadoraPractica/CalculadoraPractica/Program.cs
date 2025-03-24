using System;

namespace CalculadoraPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, este codigo funciona como una calculadora basica");

            try
            {
                Console.WriteLine("Defina que tipo de operacion seria escribiendo 1 de estos caracteres: [ + - * / ]");
                string Caracter = Console.ReadLine();
                Console.WriteLine("Deme los valores que seran utilizados");
                Console.Write("Valor 1: ");
                double n1 = Double.Parse(Console.ReadLine());
                Console.Write("Valor 2: ");
                double n2 = Double.Parse(Console.ReadLine());
                double res;



                switch (Caracter)
                {
                    
                    case "+": 
                        Console.WriteLine("Operacion");
                        Console.WriteLine(n1 + "+" + n2);
                        res = n1 + n2;
                        Console.WriteLine("Resultado = " + res);
                        
                        break;
                    case "-":
                        Console.WriteLine("Operacion");
                        Console.WriteLine(n1 + "-" + n2);
                        res = n1 - n2;
                        Console.WriteLine("Resultado = " + res);

                        break;
                    case "*":
                        Console.WriteLine("Operacion");
                        Console.WriteLine(n1 + "*" + n2);
                        res = n1 * n2;
                        Console.WriteLine("Resultado = " + res);

                        break;
                    case "/":
                        Console.WriteLine("Operacion");
                        Console.WriteLine(n1 + "/" + n2);
                        res = n1 / n2;
                        Console.WriteLine("Resultado = " + res);

                        break;

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Alguno de los valores ingresados es erroneo, intente de nuevo por favor");
            }

        }
    }
}

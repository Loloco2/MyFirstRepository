using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Feliz cumpleaños!!");
        Console.Beep(523, 500); 
        Console.Beep(659, 500);
        Console.Beep(784, 500);

        Console.WriteLine("Fuegos artificiales que compramos de la tienda china :D ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("     *       *        *       * ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("           *    *    *    *        ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("         *    *  *  *  *    *      ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("        *    *  *   *  *    *     ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("       *     *  *   *  *     *   ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("       *    *    *   *    *       ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("           *       *       *       ");
        Console.ResetColor();




        Console.WriteLine("Feliz cumpleaños profe Ingenieria>Licenciatura");
        Console.Beep(659, 125); 
        Console.Beep(659, 125); 
        Console.Beep(784, 250); 
        Console.Beep(659, 250); 
        Console.Beep(880, 250); 
        Console.Beep(784, 250); 
        Thread.Sleep(250);

        Console.Beep(659, 125);
        Console.Beep(659, 125);
        Console.Beep(784, 250);
        Console.Beep(659, 250);
        Console.Beep(987, 250);
        Console.Beep(880, 250);
        Thread.Sleep(250);

        Console.Beep(659, 125);
        Console.Beep(659, 125);
        Console.Beep(1318, 250);
        Console.Beep(1046, 250);
        Console.Beep(880, 250);
        Console.Beep(784, 250);
        Thread.Sleep(250);

        Console.Beep(880, 125);
        Console.Beep(880, 125);
        Console.Beep(784, 250);
        Console.Beep(659, 250);
        Console.Beep(784, 250);
        Console.Beep(880, 250);
        Thread.Sleep(250);

        Console.Beep(987, 125);
        Console.Beep(987, 125);
        Console.Beep(880, 250);
        Console.Beep(659, 250);
        Console.Beep(587, 250);
        Console.Beep(659, 250);
        Thread.Sleep(250);

        Console.Beep(784, 125);
        Console.Beep(784, 125);
        Console.Beep(699, 250);
        Console.Beep(659, 250);
        Console.Beep(523, 250);
        Console.Beep(587, 250);
        Thread.Sleep(250);

    }
}
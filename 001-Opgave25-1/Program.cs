using System;

namespace _001_Opgave25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ConsoleKeyInfo k = Console.ReadKey();
            if (k.Key == ConsoleKey.A) { }
            if (k.Key == ConsoleKey.Escape) { }

            // Farve
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rød");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

using System;

namespace _008_Opgave50_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int k = i * j;
                    string s = Convert.ToString(k);
                    if (k > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(s.PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}

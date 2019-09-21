using System;

namespace _002_Opgave40_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 i = new System.Int32();
            i = 10;

            i += 1;
            i -= 1;
            i += 20;
            Console.WriteLine(i);

            double d = 12.5;
            d++;
            d--;
            d *= 2;
            Console.WriteLine($"Kommatal: {d}");
        }
    }
}

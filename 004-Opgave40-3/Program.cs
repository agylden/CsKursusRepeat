using System;

namespace _004_Opgave40_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            double t1 = Convert.ToDouble(tal1);
            double t2 = Convert.ToDouble(tal2);

            double t3 = t1 + t2;
            Console.WriteLine(t3.ToString("N2"));
        }
    }
}

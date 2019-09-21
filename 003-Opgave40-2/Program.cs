using System;

namespace _003_Opgave40_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime();
            d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            Console.WriteLine();
            DateTime d2 = new DateTime();
            d2 = DateTime.Now.AddDays(2);
            Console.WriteLine(d2);
            DateTime d3 = new DateTime();
            d3 = DateTime.Now.AddDays(-2);
            Console.WriteLine(d3);
            TimeSpan t1 = d2.Subtract(d3);
            Console.WriteLine(t1.Days);

            Console.WriteLine();
            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(t3);
            TimeSpan t4 = new TimeSpan();
            t4 = t2.Subtract(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);




        }
    }
}

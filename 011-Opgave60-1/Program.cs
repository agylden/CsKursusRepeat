using System;

namespace _011_Opgave60_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53…
            Udskriv("Dette er en test"); // Dette er en test
        }

        public static int LægSammen(int a,int b)
        {
            return a + b;
        }

        public static double BeregnAreal(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}

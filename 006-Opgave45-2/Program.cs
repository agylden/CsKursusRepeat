using System;

namespace _006_Opgave45_2
{
    class Program
    {
        static void Main(string[] args)
        {
            (double sum, double gns) resultat = FindSumOgGns(5.4, 10.5);
            Console.WriteLine($"Sum: {resultat.sum:n2}");
            Console.WriteLine($"Gns: {resultat.gns:n2}");

            // eller 

            var resultat2 = FindSumOgGns(5.4, 10.5);
            Console.WriteLine($"Sum: {resultat2.sum.ToString("n2")}");
            Console.WriteLine($"Gns: {resultat2.gns:n2}");
        }

        public static (double sum,double gns) FindSumOgGns(double a, double b)
        {
            return (a + b, (a + b) / 2);
        }
    }
}

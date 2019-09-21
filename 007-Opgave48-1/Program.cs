using System;

namespace _007_Opgave48_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kort1Værdi = 2;
            KortKulør kort1Kulør = new KortKulør();
            kort1Kulør = KortKulør.Hjerter;
            Console.WriteLine(kort1Værdi);
            Console.WriteLine(kort1Kulør);

            Console.WriteLine();
            int kort2Værdi = 5;
            KortKulør kort2Kulør = new KortKulør();
            kort2Kulør = KortKulør.Ruder;
            int i = (int)kort2Kulør;
            Console.WriteLine(kort2Værdi);
            Console.WriteLine(kort2Kulør);
            Console.WriteLine(System.Convert.ToInt32(kort2Kulør));
            Console.WriteLine(i);
        }
    }

    public enum KortKulør
    {
        Spar = 0,
        Hjerter = 1,
        Ruder = 2,
        Klør = 3
    }
}

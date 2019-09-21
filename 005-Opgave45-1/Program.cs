using System;

namespace _005_Opgave45_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fornavn = "Mikkel";
            string Efternavn = "Cronberg";
            string samletNavn = Fornavn + " " + Efternavn;
            Console.WriteLine(samletNavn);

            Console.WriteLine();
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            Console.WriteLine();
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            Console.WriteLine();
            string navnDel = samletNavn.Substring(7,4);
            Console.WriteLine(navnDel);

            Console.WriteLine();
            string samletNavn2 = $"{Fornavn} {Efternavn}";
            Console.WriteLine(samletNavn2);

            Console.WriteLine();
            Console.WriteLine(Fornavn + "\r\n" + Efternavn);

            System.IO.File.WriteAllText(@"c:\temp\test.txt", samletNavn); 
        }
    }
}

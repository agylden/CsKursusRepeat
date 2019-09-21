using System;

namespace _012_Opgave60_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = System.IO.File.Exists(@"c:\temp\test.txt");
            Console.WriteLine(res);

            Console.WriteLine();
            var res1 = System.IO.File.ReadAllText(@"c:\temp\test.txt");
            Console.WriteLine(res1);

            Console.WriteLine();
            var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
            Console.WriteLine(fil);

            Console.WriteLine();
            Console.WriteLine(fil.LastAccessTime);

            Console.WriteLine();
            Console.WriteLine(fil.Extension);

            Console.WriteLine();
            Console.WriteLine(fil.Length);
        }
    }
}

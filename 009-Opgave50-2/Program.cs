using System;

namespace _009_Opgave50_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 != 0)
                    continue;
                if (i > 16)
                    break;
                Console.WriteLine(i);
            }

            // Much simpler :-)
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 ==0 & i<16)
                    Console.WriteLine(i);
            }
        }
    }
}

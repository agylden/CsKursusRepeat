using System;

namespace _010_Opgave50_3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (DateTime.Now.Millisecond > 500)
                    {
                        goto ud;
                    }
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }

        ud:
            Console.WriteLine("Færdig");
        }
    }
}

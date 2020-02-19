using System;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nº 1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nº 2: ");
            int y = int.Parse(Console.ReadLine());
            for (int i = 0; i <= y; i++ )
            {
                Console.WriteLine(x*i);
            }
        }
    }
}

using System;

namespace Test08
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("¿Que número sumo? ");
                int x = int.Parse(Console.ReadLine());
                y += x;
            }
            Console.WriteLine(y);
        }
    }
}

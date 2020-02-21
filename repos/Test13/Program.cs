using System.Collections.Generic;
using System;

namespace Test13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int> ();            
            Console.Write("¿Cuantos números van a ser? ");
            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                x.Add(int.Parse(Console.ReadLine()));
            }
            foreach ( int number in x)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es impar");
                }
            }

        }
    }
}

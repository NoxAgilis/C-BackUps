using System;

namespace Test14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Como de grande sera la matriz? ");
            int l = int.Parse(Console.ReadLine());
            int [,] x = new int[l,l];
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    x[i, j] = 0;
                    x[j, i] = 0;
                    x[i, i] = 1;
                    Console.Write(+x[i, j] + " ");
                }
                Console.WriteLine();
                

            }

        }
    }
}

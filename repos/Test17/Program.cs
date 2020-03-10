using System;

namespace Test17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantas filas quieres? ");
            int z = int.Parse(Console.ReadLine());
            for (int i = 1; i < z; i++)
            {
                for (int t = 0; t < i; t++)
                {
                    Console.Write("W ");
                }
                Console.WriteLine();
            }            
            for (int i = 1; i < z; i++)
            {
                int a = 1;
                for (int t = 0; t < i; t++)
                {
                   
                    Console.Write(+a+ " ");
                    a++;

                }
                Console.WriteLine();
            }
            for (int i = 1; i < z; i++)
            {
                for (int t = 0; t < i; t++)
                {
                    Console.Write(+i+ " ");
                }
                Console.WriteLine();
            }
            int b = 1;
            for (int i = 1; i < z; i++)
            {

                for (int t = 0; t < i; t++)
                {
                    Console.Write(b+ " ");
                    b++;
                }
                Console.WriteLine();
            }
        }
    }
}

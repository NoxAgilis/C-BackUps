using System;

namespace Test12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos números vas a introducir? ");
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < l + 1; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(+j);
                }
                Console.WriteLine();
                
            }
            int x = 1;
            for (int i = 1; i < l + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(+x + " ");
                }
                Console.WriteLine();
                x++;
            }
            x = 1;
            for (int i = 1; i < l + 1; i++)
            {
                
                for (int j = 1; j < i + 1; j++)
                {
                    
                    Console.Write(+ x + " ");
                    x++;
                }
                Console.WriteLine();

            }

        }
    }
}

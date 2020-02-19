using System;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Comprobemos si el númnero es par, ¿cual es el número? ");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0) //Compruebo si el resto (%) es cero, si lo es, el número es par, sino, es impar
            //{
            //    Console.WriteLine("El número es par");//Even
            //}
            //else
            //{
            //    Console.WriteLine("El número es impar");//Odd
            //}
            Console.Write("Ahora comprobemos si un número es multiplo, ¿cual es el primer número? ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("¿Y el segundo? ");
            int y = int.Parse(Console.ReadLine());
            if (x % y == 0)
            {
                Console.WriteLine("El primero es multiplo del segundo");
            }
            else
            {
                Console.WriteLine("El primero no es multiplo del segundo ");
            }
        }
    }
}

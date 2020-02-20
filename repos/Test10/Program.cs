using System;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos números vas a introducir? ");
            int l = int.Parse(Console.ReadLine());
            int[] list01 = new int[l];

            for (int i = 0; i < list01.Length; i++) 
            {
                Console.Write("Dime un número: " + i);
                list01[i] = int.Parse(Console.ReadLine());
            }
            int[] list02 = new int[list01.Length];

            for (int i = 0; i < list02.Length; i++)
            {
                list02[i] = list01[i];
                Console.WriteLine(list02[i]);
            }
        }
    }
}

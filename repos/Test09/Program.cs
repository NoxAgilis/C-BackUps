using System;

namespace Test09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos números vas a introducir? ");
            int l = int.Parse(Console.ReadLine());
            int[] list = new int[l];
            
            for (int i = 0; i < list.Length; i++) 
            {
                Console.Write("Dime un número: " +
                    "");
                list[i] = int.Parse(Console.ReadLine());
            }
            int r = 0;

            for (int i = 0; i < list.Length; i++) 
            {
                r += list[i];
            }
            Console.WriteLine("El resultado es " + r);

        }
    }
}

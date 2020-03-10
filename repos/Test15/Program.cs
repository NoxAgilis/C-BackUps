using System;

namespace Test15
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
                Console.Write("Dime un número: " + "");
                list[i] = int.Parse(Console.ReadLine());
            }
            foreach (int number in list)
                {
                int c = 0;
                int f = 0;
                if (c < list.Length) ;
                    {
                    int t = c++;
                    if (list[c] == list[t])
                        {
                        t++;
                        }
                    Console.WriteLine("Se repiten: " +t);
                    }
                }
        }
    }
}

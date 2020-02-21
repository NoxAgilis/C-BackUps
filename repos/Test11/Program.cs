using System;

namespace Test11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3;
            //int y = 4;
            //int aux = x;
            //x = y;
            //y = aux;
            //Console.Write("¿Cuantos números vas a introducir? ");
            //int l = int.Parse(Console.ReadLine());
            //int[] list = new int[l];

            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.Write("Dime un número: ");
            //    list[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < list.Length; i++)
            //{
            //    for (int j = i + 1; j < list.Length; j++)
            //    {
            //        if (list[j] < list[i])
            //        {
            //            int aux = list[i];
            //            list[i] = list[j];
            //            list[j] = aux;
            //        }
            //    }
            //}

            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.Write("¿Cuantos números vas a introducir? ");
            //int l = int.Parse(Console.ReadLine());
            //int[] list = new int[l];

            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.Write("Dime un número: ");
            //    list[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < list.Length; i++)
            //{
            //    for (int j = i + 1; j < list.Length; j++)
            //    {
            //        if (list[j] == list[i])
            //        {
            //            Console.WriteLine("Hay un duplicado");
            //        }                   
            //    }
            //}

            Console.Write("¿Cuantos números vas a introducir? ");
            int l = int.Parse(Console.ReadLine());
            int[] list = new int[l];

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Dime un número: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            int x = -300000000;
            int y = 300000000;
            
            for (int i = 0; i < list.Length; i++)
            {
                    if (list[i] > x)
                    {
                        x = list[i];
                        
                    }
                     if (list[i] < y)
                    {
                        y = list[i];
                       
                    }
                    
                
            }
            Console.WriteLine("El número más grande es: " + x);
            Console.WriteLine("El número más pequeño es: " + y);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Test18
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> x = new List<int> ();
            //Console.Write("¿La longitud de la lista? ");
            //int l = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dime los números ");
            //for (int i = 0; i < l; i++)
            //{
            //    x.Add(int.Parse(Console.ReadLine()));
            //}
            //for (int i = x.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(x[i]);
            //}
            //List<int> x = new List<int>();
            //Console.Write("¿Cuantos números van a ser? ");
            //int l = int.Parse(Console.ReadLine());
            //for (int i = 0; i < l; i++)
            //{
            //    x.Add(int.Parse(Console.ReadLine()));
            //}            
            //for (int i = 0; i < x.Count; i++)
            //{
            //    for (int j = i + 1; j < x.Count; j++)
            //    {
            //        if (x[j] < x[i])
            //        {
            //            int aux = x[i];
            //            x[i] = x[j];
            //            x[j] = aux;
            //        }
            //    }
            //}
            //for (int i = 0; i < x.Count; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}
            int x = 0;
            do
            {
                Console.WriteLine("Con el 1 sumas, el 2 resta, el 3 multiplica, el 4 divide y el 5 cierra, ¿cual quieres? ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.Write("Dime el primer número: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Dime el segundo número: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine((a + b));
                        break;
                    case 2:
                        Console.Write("Dime el primer número: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("Dime el segundo número: ");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine((c - d));

                        break;
                    case 3:
                        Console.Write("Dime el primer número: ");
                        int e = int.Parse(Console.ReadLine());
                        Console.Write("Dime el segundo número: ");
                        int f = int.Parse(Console.ReadLine());
                        Console.WriteLine((e * f));
                        break;
                    case 4:
                        Console.Write("Dime el primer número: ");
                        int g = int.Parse(Console.ReadLine());
                        Console.Write("Dime el segundo número: ");
                        int h = int.Parse(Console.ReadLine());
                        Console.WriteLine((g / h));
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("Eso no");
                        break;
                }
            } while (x != 5);
        }
    }
}

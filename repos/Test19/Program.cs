using System;
using System.Collections.Generic;

namespace Test19
{
    class Program
    {
        static int Quest(string text)
        {
            Console.Write(text);
            return int.Parse(Console.ReadLine());
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Res(int x, int y)
        {
            return x - y;
        }
        static int Mul(int x, int y)
        {
            return x * y;
        }
        static int Div(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            int x = Quest("¿El primer número? ");
            int y = Quest("¿El segundo número? ");
            int s = 0;
            do
            {
                 s = Quest("Con el 1 sumas, el 2 resta, el 3 multiplica, el 4 divide y el 5 cierra, ¿cual quieres? ");

                switch (s)
                {
                    case 1:
                        Console.WriteLine(Sum(x, y));
                        break;
                    case 2:
                        Console.WriteLine(Res(x, y));
                        break;
                    case 3:
                        Console.WriteLine(Mul(x, y));
                        break;
                    case 4:
                        Console.WriteLine(Div(x, y));
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("Eso no");
                        break;
                }
            } while (s  != 5);
        }
    }
}

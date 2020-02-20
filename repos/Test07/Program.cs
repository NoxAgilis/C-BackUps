using System;

namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("¿Hasta que número quieres que cuente? ");
            //int x = int.Parse(Console.ReadLine());
            //int i = x;
            //while (i <= x)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= x);
            //i = 1;
            //for (; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Write("¿Que número quieres? ");
            //int x = int.Parse(Console.ReadLine());
            //int i = 0;
            //int y = 0;
            //for (; i <= x; i++)
            //{
            //    y += i;
            //}
            //Console.Write(y);
            //Console.Write("¿Hasta que número quieres que cuente? ");
            //int x = int.Parse(Console.ReadLine());
            //int i = x;
            //for (; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //i = x;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //} while (i >= 0);
            //i = x;
            //while (i >= 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            int x = 0;
            do
            {
                Console.WriteLine("¿Que quieres del 1 al 4? ");
                x = int.Parse(Console.ReadLine()); //A C# no les gusttan las variables dentro de los mismos corchetes y un switch o cualquier cosa asi
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Pajaro en mano vale mas que mil volando");
                        break;
                    case 2:
                        Console.WriteLine("Van dos y se cae el de enmedio");
                        break;
                    case 3:
                        Console.WriteLine("Tus muerto, joh' putah'");
                        break;
                    case 4:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("Eso no");
                        break;
                }
            } while (x != 4);
        }
    }
}


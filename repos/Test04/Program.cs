using System;

namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Intruduce un número: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 0)
            //{
            //    if (x == 0)
            //    {
            //        Console.WriteLine("El número es cero");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número es positivo");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El número es negativo");
            //}
            //Console.Write("¿Que elijes, la 1, la 2 o la 3? ");
            //int x = int.Parse(Console.ReadLine());
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("Pajaro en mano vale más que mil volando.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Van dos y se cae el de enmedio.");
            //        break;
            //    case 3:
            //        Console.WriteLine("No te me pongas remolon, tapón de alberca.");
            //        break;
            //    default:
            //        Console.WriteLine("Que gracioso, pues ahora te quedas sin cenar.");
            //        break;
            //}
            //Console.Write("Dime un número: ");
            //float x = float.Parse(Console.ReadLine());
            //Console.Write("Dime otro número: ");
            //float y = float.Parse(Console.ReadLine());
            //Console.Write("Dime el ultimo número: ");
            //float z = float.Parse(Console.ReadLine());
            //float f = ((x + y + z) / 3);
            //Console.WriteLine("La media de tus notas es: " +f );
            Console.Write("¿Cual es tu altura en centimetros?: ");
            int z = int.Parse(Console.ReadLine());
            if (z < 135 )
            {
                Console.WriteLine("¿Todavia vas parbulitos?");
            }
        }
    }
}

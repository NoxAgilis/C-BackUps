using System;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vamos a multiplicar, ¿que número quieres multiplicar? ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Hasta que multiplo? ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            while (c <= b) 
            {
                Console.WriteLine(+ a + "x" + c + "=" + (a * c));
                c++;
            }
        }
    }
}

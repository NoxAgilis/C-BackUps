using System;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Comparemos dos nuemros, ¿cual es el primero? ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("¿Cual es el segundo? ");
            int b = int.Parse(Console.ReadLine());
            if (a == b) //Comparo los numeros, este es el caso en el que ambos son identicos
            {
                Console.WriteLine("Ambos son identicos.");
            }
            else //Este es el caso contrario, en el caso que son diferentes
            {
                Console.Write("Son numeros diferentes, el mayor es: ");
                if (a < b) //Ahora compruebo cual es mayor, aqui compruebo que a es menor que b
                {
                    Console.WriteLine(+b);
                }
                else //En este caso, a es mayor
                {
                    Console.WriteLine(+a);
                }
            }

        }
    }
}

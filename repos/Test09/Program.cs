using System;

namespace Test09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos números vas a introducir? ");//Pide la cantidad de digitos a introducir
            int l = int.Parse(Console.ReadLine());
            int[] list = new int[l];//Creo una Array
            
            for (int i = 0; i < list.Length; i++) //Modifico los huecos del Array uno a uno
            {
                Console.Write("Dime un número: " +i);
                list[i] = int.Parse(Console.ReadLine());
            }
            int r = 0;//Creo la variable de resultado

            for (int i = 0; i < list.Length; i++)//Sumo todos los valores dentro del Array 
            {
                r += list[i];
            }
            Console.WriteLine("El resultado es " + r);//Muestro el resultado

        }
    }
}

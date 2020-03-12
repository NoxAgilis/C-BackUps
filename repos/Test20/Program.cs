using System;

namespace Test20
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("¿El nombre? ");
            string nom = Console.ReadLine();
            Console.Write("¿El día? ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("¿El mes? ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("¿El año? ");
            int yea = int.Parse(Console.ReadLine());
            Empleado empledado = new Empleado(nom, dia, mes, yea);
            Console.WriteLine();
            Console.WriteLine();
            empleado.Show();
        }
    }
}

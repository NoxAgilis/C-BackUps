using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Que nota has sacado en el utimo examen? ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {//Determinamos la nota con switch
                case 10:
                case 9:
                    Console.WriteLine("Sobresaliente");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Insuficiente");
                    break;
                default:
                    Console.WriteLine("No es valida");
                    break;
            }
                   { //Determinamos la nota con if y else
                        if (n >= 9 && n <= 10)
                        {
                            Console.WriteLine("Sobresaliente");
                        }
               
                        else if (n < 9 && n >= 7)
                        {
                            Console.WriteLine("Notable");
                        }
                        else if (n < 7 && n >= 6)
                        {
                            Console.WriteLine("Bien");
                        }
                        else if (n < 6 && n >= 5)
                        {
                            Console.WriteLine("Suficiente");
                        }
                        else if (n < 5 && n >= 0)
                        {
                            Console.WriteLine("Insuficiente");
                        }
                        else
                        {
                            Console.WriteLine("Esa nota no es valida");
                        }
                    }
            {
                //Declaración de variable de tipo integer
                //llamada "x".
                int x;
                //Inicialización de la variable llamada "x"
                //con el valor 1.
                x = 1;

                //Declaración e inicialización.
                int y = 3;

                //Declaración e inicialización.
                float z = 2.5f;

                //Decalración e inicialización.
                double w = 5.67484d;
                x = y;

                char let = 'B';
                string fra = "Hello World!";
                bool booleanoFalso = false;
                bool booleanoVerdadero = true;

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.WriteLine(w);
                Console.WriteLine(let);
                Console.WriteLine(fra);
                Console.WriteLine(booleanoFalso);
                Console.WriteLine(booleanoVerdadero);
                Console.Write("Doh! ");
                Console.WriteLine("No se operar, ¿me ayudas?");
                Console.Write("Dime el primer factor "); //Pide el primer número
                int a = int.Parse(Console.ReadLine());
                Console.Write("Dime el segundo factor "); //Pide el segundo número
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("La suma de " + a + " y " + b + " es " + (a + b)); //Realiza la suma
                Console.WriteLine("La resta de " + a + " y " + b + " es " + (a - b)); //Realiza la resta 
                Console.WriteLine("La multiplicación de " + a + " y " + b + " es " + (a * b)); //Realiza la multiplcación
                Console.WriteLine("Y la division entre " + a + " y " + b + " es " + (a / b) + " con resto " + (a % b) + " ... ¿O no?"); //Realiza la división y da el resto

                Console.WriteLine("¿Cual es tu edad? ");
                int c = int.Parse(Console.ReadLine());

                if (c < 18)
                {
                    Console.WriteLine("Eres menor de edad.");
                }
                else if (c < 65)
                {
                    Console.WriteLine("Eres mayor de edad.");
                }
                else if (c >= 65)
                {
                    Console.WriteLine("Eres un yayo");
                }
            }
        }
    }
    
}

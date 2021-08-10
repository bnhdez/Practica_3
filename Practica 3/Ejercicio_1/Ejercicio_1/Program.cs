using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, num, prod = 1;
            
            Console.WriteLine("Ingrese un numero del 1 al 10");
            num = int.Parse(Console.ReadLine());

            while (contador <= 10)
            {
                prod = num * prod;

                Console.WriteLine("La multiplicacion es "+ num +"x"+ contador, "=", prod);

                contador = contador + 1;
            }

            
        }
    }
}

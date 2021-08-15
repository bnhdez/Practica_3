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
            
            //mientras el contador sea menor a 10, el ciclo se repite
            while (contador <= 10)
            {
                //el producto es el resultado de multiplicar el numero ingresado por el contador que aumenta 1 cada vez
                prod = num * contador;

                Console.WriteLine("La multiplicacion es "+ num +"x"+ contador+ "="+ prod);

                contador = contador + 1;
            }

            
        }
    }
}

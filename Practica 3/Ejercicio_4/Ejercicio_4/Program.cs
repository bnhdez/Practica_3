using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double muestra;
            int cont = 1;

            Console.WriteLine("***********Ingrese las 25 muestras recibidas en una hora***********");
            while (cont <= 5)
            {
                Console.WriteLine("Muestra " + cont);
                muestra = double.Parse(Console.ReadLine());

                if ((muestra >= 0.5977) && (muestra <= 0.8239))
                {
                    Console.WriteLine("Bajo Control!");
                }
                else 
                {
                    Console.WriteLine("No esta dentro de los parametros de control");
                }

                cont = cont + 1;
            }

        }
    }
}

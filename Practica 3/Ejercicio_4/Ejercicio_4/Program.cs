using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double muestra, promedio, total = 0;
            int cont = 1;

            Console.WriteLine("***********Ingrese las 25 muestras recibidas en una hora***********");
            //este ciclo while sirve para tomar los datos de todas las muestras
            while (cont <= 25)
            {
                Console.WriteLine("Muestra " + cont);
                muestra = double.Parse(Console.ReadLine());
                //total sera la suma de las muestras
                total = total + muestra;

                //condicion if para establecer los parametros de control
                if ((muestra >= 0.5977) && (muestra <= 0.8239))
                {
                    Console.WriteLine("Bajo Control!");
                }
                else 
                {
                    Console.WriteLine("Fuera de control!");
                }
                cont = cont + 1;
            }
            promedio = total / 25;
            Console.WriteLine("El promedio de las muestras es de: " + promedio);
        }
    }
}

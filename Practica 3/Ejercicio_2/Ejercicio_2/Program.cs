using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, pass;
            string user;
            
            // n servira como contador de numero de intentos
            while (n != 3)
            {
                Console.WriteLine("Ingrese su usuario: ");
                user = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña numerica: ");
                pass = int.Parse(Console.ReadLine());

                //condicion if en caso ingrese usuario y contraseña correcta
                if ((user == "usuario1") && (pass == 123))
                {
                    Console.WriteLine("BIENVENIDO!");
                    n = 3;
                }
                else
                {
                    //el ciclo continua hasta llegar a los 3 intentos
                    n = n + 1;
                    if (n == 3)
                    {
                        Console.WriteLine("Error de contraseña. Consulte con administrador del sistema");
                    }
                } 
            }
        }
    }
}

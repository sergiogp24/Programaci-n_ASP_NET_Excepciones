using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write("Ingresa un número: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Valor no válido");
                    continue;
                }

                try
                {
                    if (numero < 0)
                        throw new Exception("El número no puede ser negativo");
                    valido = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.WriteLine("Número aceptado: " + numero);
        }
    }
}


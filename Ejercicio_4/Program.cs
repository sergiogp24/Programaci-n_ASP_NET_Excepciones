using System;
using System.Collections.Generic;
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productos = new Dictionary<string, decimal>()
            {
                { "Laptop", 1500m },
                { "Mouse", 25m },
                { "Teclado", 45m }
            };

            while (true)
            {
                Console.Write("Ingresa producto (o 'salir' para terminar): ");
                string producto = Console.ReadLine();

                if (producto.ToLower() == "salir")
                    break;

                if (!productos.TryGetValue(producto, out decimal precio))
                {
                    Console.WriteLine("Producto no encontrado");
                    continue;
                }

                Console.Write("Cantidad: ");
                string cantidadStr = Console.ReadLine();
                if (!int.TryParse(cantidadStr, out int cantidad))
                {
                    Console.WriteLine("Cantidad no válida");
                    continue;
                }

                decimal total = precio * cantidad;
                Console.WriteLine("Total: " + total);
            }
        }
    }
}


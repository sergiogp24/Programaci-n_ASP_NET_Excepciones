using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> alumnos = new Dictionary<string, int>()
            {
                { "Ana", 25 },
                { "Luis", 30 }
            };

            Console.Write("Ingresa nombre del alumno: ");
            string nombre = Console.ReadLine();

            if (alumnos.TryGetValue(nombre, out int edad))
            {
                Console.WriteLine("Edad: " + edad);
            }
            else
            {
                Console.WriteLine("Alumno no encontrado");
            }
        }
    }
}

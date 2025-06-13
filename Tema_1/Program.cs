using System;
using System.Collections.Generic;

namespace JerarquiaDatos
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre,-15} | Edad: {Edad,3} | Ciudad: {Ciudad}");
            // {cadena,numero} el numero indica cuantos espacios voy a reservar
            // un numero positivo reserva x espacios a la derecha para la cadena
            // Un numero negativo reserva x espacios a la izquierda para la cadena

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            Console.WriteLine("=== Registro de Personas ===");

            while (true)
            {
                Console.WriteLine("Ingrese el nombre (o escriba \"fin\" para terminar)");
                string nombre = Console.ReadLine();
                if (nombre.ToLower() == "fin")
                {
                    break;
                }

                int edad;
                Console.WriteLine("Ingrese la edad: ");
                while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
                {
                    Console.WriteLine("Ingrese una edad válida");
                }

                Console.WriteLine("Ingrese la ciudad: ");
                string ciudad = Console.ReadLine();

                personas.Add(new Persona(edad: edad, nombre: nombre, ciudad: ciudad));
                Console.WriteLine(">> Persona registrada \n");

                Console.WriteLine("\n=== Lista de Personas Ingresadas ===");
                foreach (var persona in personas)
                {
                    persona.Mostrar();
                }

            }
        }
    }
}
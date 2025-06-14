using System;
using System.IO;

namespace tema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string crearArchivo = @"C:\Users\decto\Desktop\archivo2.txt"; // variable que almacena la ruta del archivo a crear
            string[] articulos = new string[3];

            //Ingreso de articulos al arreglo
            Console.WriteLine("Ingrese tres articulos: ");

            for (int i = 0; i < articulos.Length; i++)
            {
                Console.Write($"Articulo {i + 1}: ");
                articulos[i] = Console.ReadLine();
            }

            //Escribir datos del arreglo en el archivo
            File.WriteAllText(crearArchivo, string.Join("|", articulos));

            //Leer archivo
            string leerArchivo = File.ReadAllText(crearArchivo);
            Console.WriteLine($"Contenido del archivo: {leerArchivo}");
        }
    }
}
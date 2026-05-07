using SimulacroV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimulacroV2
{
    internal class Program
    {
        // Cambia el método guardarLibro a estático para que pueda ser llamado desde Main
        public static void guardarLibro(List<Libro> libros, string ruta)
        {
            StreamWriter escritor = File.CreateText(ruta);
            foreach (Libro libro in libros)
            {
                escritor.WriteLine(libro.ToString());
            }
            escritor.Close();
        }

        public static void Main(String[] args)
        {

            List<Libro> libros = new List<Libro>();
            libros.Add(new Libro("El Quijote", "Miguel de Cervantes", 1605, true));
            libros.Add(new Libro("Cien años de soledad", "Gabriel García Márquez", 1967, true));
            libros.Add(new Libro("La sombra del viento", "Carlos Ruiz Zafón", 2001, true));

            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro.ToString());

            }
            foreach (Libro libro in libros)
            {
                if (libro.ToString().Contains("Miguel"))
                {
                    Console.WriteLine("El Libro que contiene a este autor es: " + libro.ToString());
                }
            }

            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(fechaActual.ToShortDateString());
            foreach (Libro libro in libros)
            {
                guardarLibro(libros, "D:\\EDE\\libros.txt");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using BibliotecaEscolar.Models;

namespace BibliotecaEscolar
{
    class Program
    {
        static void Main()
        {
            List<Titulo> catalogo = new List<Titulo>
            {
                new Titulo { Id = 1, Nombre = "Don Quijote", Autor = "Cervantes", ISBN = "978-8424922405", PrestamosHistoricos = 15, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 101, CodigoBarras = "DQ-01", Estado = "Disponible" }, new Ejemplar { Id = 102, CodigoBarras = "DQ-02", Estado = "Disponible" } } },
                new Titulo { Id = 2, Nombre = "Cien Anos de Soledad", Autor = "Garcia Marquez", ISBN = "978-0307474728", PrestamosHistoricos = 28, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 201, CodigoBarras = "CS-01", Estado = "Disponible" } } },
                new Titulo { Id = 3, Nombre = "El Principito", Autor = "Saint-Exupery", ISBN = "978-0156013987", PrestamosHistoricos = 42, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 301, CodigoBarras = "EP-01", Estado = "Disponible" } } }
            };

            Console.WriteLine("DIA 3: TRES PRESTAMOS SIMULADOS\n");

            // Función ultra corta para prestar un ejemplar
            void Prestar(Titulo t, int idx)
            {
                if (idx < t.Ejemplares.Count && t.Ejemplares[idx].Estado == "Disponible")
                {
                    t.Ejemplares[idx].Estado = "Prestado";
                    t.PrestamosHistoricos++;
                    Console.WriteLine($"[PRESTAMO EXITOSO] {t.Nombre} ({t.Ejemplares[idx].CodigoBarras})");
                }
            }
            Prestar(catalogo[0], 0); // Prestamo de don quijotes
            Prestar(catalogo[0], 1); // Prestamo igual DQ
            Prestar(catalogo[1], 0); // Préstamo Cienaños

            Console.WriteLine("\n DISPONIBILIDAD Y CATALOGO FINAL");
            foreach (var t in catalogo)
            {
                int disponibles = t.Ejemplares.FindAll(e => e.Estado == "Disponible").Count;
                Console.WriteLine($"\n{t.Nombre} | Disponibles: {disponibles}/{t.Ejemplares.Count} | Histórico: {t.PrestamosHistoricos}");
                foreach (var e in t.Ejemplares)
                    Console.WriteLine($"  - Ejemplar {e.CodigoBarras}: {e.Estado}");
            }
        }
    }
}
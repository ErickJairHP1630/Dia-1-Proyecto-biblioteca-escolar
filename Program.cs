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
                new Titulo { Id = 1, Nombre = "Don Quijote", Autor = "Cervantes", ISBN = "978-8424922405", PrestamosHistoricos = 15, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 101, CodigoBarras = "DQ-01", Estado = "Disponible" }, new Ejemplar { Id = 102, CodigoBarras = "DQ-02", Estado = "Disponible" }, new Ejemplar { Id = 103, CodigoBarras = "DQ-03", Estado = "Disponible" } } },
                new Titulo { Id = 2, Nombre = "Cien Anos de Soledad", Autor = "Garcia Marquez", ISBN = "978-0307474728", PrestamosHistoricos = 28, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 201, CodigoBarras = "CS-01", Estado = "Disponible" } } },
                new Titulo { Id = 3, Nombre = "El Principito", Autor = "Saint-Exupery", ISBN = "978-0156013987", PrestamosHistoricos = 42, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 301, CodigoBarras = "EP-01", Estado = "Disponible" }, new Ejemplar { Id = 302, CodigoBarras = "EP-02", Estado = "Disponible" }, new Ejemplar { Id = 303, CodigoBarras = "EP-03", Estado = "Disponible" }, new Ejemplar { Id = 304, CodigoBarras = "EP-04", Estado = "Disponible" }, new Ejemplar { Id = 305, CodigoBarras = "EP-05", Estado = "Disponible" } } },
                new Titulo { Id = 4, Nombre = "Fahrenheit 451", Autor = "Bradbury", ISBN = "978-1451673319", PrestamosHistoricos = 10, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 401, CodigoBarras = "F4-01", Estado = "Disponible" }, new Ejemplar { Id = 402, CodigoBarras = "F4-02", Estado = "Disponible" } } },
                new Titulo { Id = 5, Nombre = "1984", Autor = "Orwell", ISBN = "978-0451524935", PrestamosHistoricos = 35, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 501, CodigoBarras = "19-01", Estado = "Disponible" }, new Ejemplar { Id = 502, CodigoBarras = "19-02", Estado = "Disponible" }, new Ejemplar { Id = 503, CodigoBarras = "19-03", Estado = "Disponible" }, new Ejemplar { Id = 504, CodigoBarras = "19-04", Estado = "Disponible" } } },
                new Titulo { Id = 6, Nombre = "Pedro Paramo", Autor = "Rulfo", ISBN = "978-8437604183", PrestamosHistoricos = 8, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 601, CodigoBarras = "PP-01", Estado = "Disponible" } } },
                new Titulo { Id = 7, Nombre = "Rayuela", Autor = "Cortazar", ISBN = "978-8437604572", PrestamosHistoricos = 15, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 701, CodigoBarras = "RY-01", Estado = "Disponible" }, new Ejemplar { Id = 702, CodigoBarras = "RY-02", Estado = "Disponible" }, new Ejemplar { Id = 703, CodigoBarras = "RY-03", Estado = "Disponible" } } },
                new Titulo { Id = 8, Nombre = "La Metamorfosis", Autor = "Kafka", ISBN = "978-8420651361", PrestamosHistoricos = 20, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 801, CodigoBarras = "LM-01", Estado = "Disponible" }, new Ejemplar { Id = 802, CodigoBarras = "LM-02", Estado = "Disponible" } } }
            };

            Console.WriteLine("BIBLIOTECA ESCOLAR");
            foreach (var t in catalogo)
            {
                Console.WriteLine($"ID: {t.Id} | Titulo: {t.Nombre} | Ejemplares: {t.Ejemplares.Count}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using BibliotecaEscolar.Models;

namespace BibliotecaEscolar
{
    class Program
    {
        static void Main()
        {
            // Carga de títulos 
            List<Titulo> catalogo = new List<Titulo>
            {
                new Titulo { Id = 1, Nombre = "Don Quijote", Autor = "Cervantes", ISBN = "978-8424922405", PrestamosHistoricos = 15, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 101, CodigoBarras = "DQ-01", Estado = "Disponible" }, new Ejemplar { Id = 102, CodigoBarras = "DQ-02", Estado = "Disponible" } } },
                new Titulo { Id = 2, Nombre = "Cien Anos de Soledad", Autor = "Garcia Marquez", ISBN = "978-0307474728", PrestamosHistoricos = 28, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 201, CodigoBarras = "CS-01", Estado = "Disponible" } } },
                new Titulo { Id = 3, Nombre = "El Principito", Autor = "Saint-Exupery", ISBN = "978-0156013987", PrestamosHistoricos = 42, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 301, CodigoBarras = "EP-01", Estado = "Disponible" } } },
                new Titulo { Id = 4, Nombre = "Ficciones", Autor = "Jorge Luis Borges", ISBN = "978-8420633121", PrestamosHistoricos = 17, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 401, CodigoBarras = "FC-01", Estado = "Disponible" } } },
                new Titulo { Id = 5, Nombre = "Pedro Paramo", Autor = "Juan Rulfo", ISBN = "978-8437604183", PrestamosHistoricos = 29, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 501, CodigoBarras = "PP-01", Estado = "Disponible" } } },
                new Titulo { Id = 6, Nombre = "Rayuela", Autor = "Julio Cortazar", ISBN = "978-8437604572", PrestamosHistoricos = 17, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 601, CodigoBarras = "RY-01", Estado = "Disponible" } } },
                new Titulo { Id = 7, Nombre = "La Galatea", Autor = "Cervantes", ISBN = "978-8437608402", PrestamosHistoricos = 5, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 701, CodigoBarras = "LG-01", Estado = "Disponible" } } },
                new Titulo { Id = 8, Nombre = "Aura", Autor = "Carlos Fuentes", ISBN = "978-9681608781", PrestamosHistoricos = 10, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 801, CodigoBarras = "AU-01", Estado = "Disponible" } } }
            };

            Console.WriteLine(" DIA 3: TRES PRESTAMOS SIMULADOS ");

            void Prestar(Titulo t, int idx)
            {
                if (idx < t.Ejemplares.Count && t.Ejemplares[idx].Estado == "Disponible")
                {
                    t.Ejemplares[idx].Estado = "Prestado";
                    t.PrestamosHistoricos++;
                    Console.WriteLine($"[PRESTAMO EXITOSO] {t.Nombre} ({t.Ejemplares[idx].CodigoBarras})");
                }
            }

            Prestar(catalogo[0], 0);
            Prestar(catalogo[0], 1); 
            Prestar(catalogo[1], 0); 

            Console.WriteLine("\n=== DIA 4: ORDENAMIENTO POR INSERCION MANUAL ===");
            OrdenarPorInsercion(catalogo);

            Console.WriteLine("\n=== CATALOGO FINAL ORDENADO (MAYOR A MENOR PRÉSTAMOS) ===");
            foreach (var t in catalogo)
            {
                int disponibles = t.Ejemplares.FindAll(e => e.Estado == "Disponible").Count;
                Console.WriteLine($"\n{t.Nombre} | Disponibles: {disponibles}/{t.Ejemplares.Count} | Histórico: {t.PrestamosHistoricos}");
                foreach (var e in t.Ejemplares)
                    Console.WriteLine($"  - Ejemplar {e.CodigoBarras}: {e.Estado}");
            }

            Console.WriteLine("\n=== DIA 5: BUSQUEDAS ===");

            // Búsqueda Secuencial por Nombre
            BuscarPorNombre(catalogo, "El Principito");
            BuscarPorNombre(catalogo, "Harry Potter"); // Caso no encontrado

            // Búsqueda Binaria por ISBN (requiere ordenar por ISBN primero)
            OrdenarPorISBN(catalogo);
            BuscarPorISBN(catalogo, "978-0156013987");
            BuscarPorISBN(catalogo, "000-0000000000"); // Caso no encontrado
        }

        public static void OrdenarPorInsercion(List<Titulo> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Titulo clave = lista[i];
                int j = i - 1;

                while (j >= 0 && DebeIntercambiar(lista[j], clave))
                {
                    lista[j + 1] = lista[j];
                    j--;
                }

                lista[j + 1] = clave;
            }
        }

        private static bool DebeIntercambiar(Titulo actual, Titulo clave)
        {
            if (clave.PrestamosHistoricos > actual.PrestamosHistoricos) return true;

            if (clave.PrestamosHistoricos == actual.PrestamosHistoricos)
            {
                if (string.Compare(clave.Nombre, actual.Nombre, StringComparison.OrdinalIgnoreCase) < 0) return true;
            }

            return false;
        }
        // Búsqueda secuencial recorriendo la lista uno por uno
        public static void BuscarPorNombre(List<Titulo> lista, string nombre)
        {
            foreach (var t in lista)
            {
                if (t.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    int disp = t.Ejemplares.FindAll(e => e.Estado == "Disponible").Count;
                    Console.WriteLine($"[ENCONTRADO] {t.Nombre} | ISBN: {t.ISBN} | Disponibles: {disp}");
                    return;
                }
            }
            Console.WriteLine($"[NO ENCONTRADO] El título '{nombre}' no existe.");
        }
        // Búsqueda binaria dividiendo a la mitad por ISBN
        public static void BuscarPorISBN(List<Titulo> lista, string isbn)
        {
            int i = 0, f = lista.Count - 1;
            while (i <= f)
            {
                int m = (i + f) / 2;
                int cmp = string.Compare(lista[m].ISBN, isbn);

                if (cmp == 0)
                {
                    int disp = lista[m].Ejemplares.FindAll(e => e.Estado == "Disponible").Count;
                    Console.WriteLine($"[ENCONTRADO ISBN] {lista[m].Nombre} | Disponibles: {disp}");
                    return;
                }
                if (cmp < 0) i = m + 1;
                else f = m - 1;
            }
            Console.WriteLine($"[NO ENCONTRADO ISBN] El ISBN '{isbn}' no existe.");
        }
        // Ordenamiento rápido por ISBN para permitir búsqueda binaria
        private static void OrdenarPorISBN(List<Titulo> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Titulo clave = lista[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(lista[j].ISBN, clave.ISBN) > 0)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = clave;
            }
        }
    }
}
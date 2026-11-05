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
                new Titulo { Id = 3, Nombre = "El Principito", Autor = "Saint-Exupery", ISBN = "978-0156013987", PrestamosHistoricos = 42, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 301, CodigoBarras = "EP-01", Estado = "Disponible" } } },
                new Titulo { Id = 4, Nombre = "Ficciones", Autor = "Jorge Luis Borges", ISBN = "978-8420633121", PrestamosHistoricos = 17, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 401, CodigoBarras = "FC-01", Estado = "Disponible" } } },
                new Titulo { Id = 5, Nombre = "Pedro Paramo", Autor = "Juan Rulfo", ISBN = "978-8437604183", PrestamosHistoricos = 29, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 501, CodigoBarras = "PP-01", Estado = "Disponible" } } },
                new Titulo { Id = 6, Nombre = "Rayuela", Autor = "Julio Cortazar", ISBN = "978-8437604572", PrestamosHistoricos = 17, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 601, CodigoBarras = "RY-01", Estado = "Disponible" } } },
                new Titulo { Id = 7, Nombre = "La Galatea", Autor = "Cervantes", ISBN = "978-8437608402", PrestamosHistoricos = 5, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 701, CodigoBarras = "LG-01", Estado = "Disponible" } } },
                new Titulo { Id = 8, Nombre = "Aura", Autor = "Carlos Fuentes", ISBN = "978-9681608781", PrestamosHistoricos = 10, Ejemplares = new List<Ejemplar> { new Ejemplar { Id = 801, CodigoBarras = "AU-01", Estado = "Disponible" } } }
            };

            // Para hacer búsqueda binaria, el catálogo DEBE estar ordenado por ISBN primero
            OrdenarPorISBN(catalogo);

            Console.WriteLine("==================================================");
            Console.WriteLine("  DIA 7: BÚSQUEDA BINARIA E INTERACTIVA POR ISBN");
            Console.WriteLine("==================================================\n");

            // Mostrar el catálogo con sus ISBNs disponibles para que el usuario pueda elegir
            Console.WriteLine("CATÁLOGO DISPONIBLE (ORDENADO POR ISBN):");
            foreach (var t in catalogo)
            {
                Console.WriteLine($" ISBN: {t.ISBN} | Título: {t.Nombre}");
            }

            Console.WriteLine("\n--------------------------------------------------");
            Console.Write("Ingrese el ISBN a buscar: ");
            string isbnIngresado = Console.ReadLine()?.Trim();

            // Ejecución de la búsqueda binaria
            BuscarBinariaInteractiva(catalogo, isbnIngresado);
        }

        // Método de Búsqueda Binaria que muestra la ficha detallada del libro y mide las comparaciones
        public static void BuscarBinariaInteractiva(List<Titulo> lista, string isbnBuscado)
        {
            int inicio = 0;
            int fin = lista.Count - 1;
            int comparaciones = 0;
            Titulo encontrado = null;

            while (inicio <= fin)
            {
                comparaciones++;
                int medio = (inicio + fin) / 2;
                int cmp = string.Compare(lista[medio].ISBN, isbnBuscado, StringComparison.OrdinalIgnoreCase);

                if (cmp == 0)
                {
                    encontrado = lista[medio];
                    break;
                }
                if (cmp < 0) inicio = medio + 1;
                else fin = medio - 1;
            }

            // Verificación nativa para la medición exigida por el Día 7
            string[] arrayISBNs = lista.ConvertAll(t => t.ISBN).ToArray();
            int idxNativo = Array.BinarySearch(arrayISBNs, isbnBuscado);

            Console.WriteLine("\n================ FICHA DEL LIBRO ================");
            if (encontrado != null)
            {
                int disponibles = encontrado.Ejemplares.FindAll(e => e.Estado == "Disponible").Count;
                Console.WriteLine($" TÍTULO:      {encontrado.Nombre}");
                Console.WriteLine($" AUTOR:       {encontrado.Autor}");
                Console.WriteLine($" ISBN:        {encontrado.ISBN}");
                Console.WriteLine($" PRÉSTAMOS:   {encontrado.PrestamosHistoricos}");
                Console.WriteLine($" DISPONIBLES: {disponibles}/{encontrado.Ejemplares.Count}");
                Console.WriteLine("\n EJEMPLARES:");
                foreach (var ej in encontrado.Ejemplares)
                {
                    Console.WriteLine($"   - Código: {ej.CodigoBarras} | Estado: {ej.Estado}");
                }
            }
            else
            {
                Console.WriteLine($" [NO ENCONTRADO] El ISBN '{isbnBuscado}' no existe en el sistema.");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($" METRICAS DIA 7:");
            Console.WriteLine($" Comparaciones realizadas (Algoritmo propio): {comparaciones}");
            Console.WriteLine($" Verificación Array.BinarySearch: {(idxNativo >= 0 ? "Encontrado" : "No Encontrado")}");
            Console.WriteLine("==================================================");
        }

        private static void OrdenarPorISBN(List<Titulo> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Titulo clave = lista[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(lista[j].ISBN, clave.ISBN, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = clave;
            }
        }
    }
}
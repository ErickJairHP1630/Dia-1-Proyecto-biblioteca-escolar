using System;
using System.Collections.Generic;
using BibliotecaEscolar.Models;

namespace BibliotecaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIBLIOTECA ESCOLAR ===");
            Console.WriteLine();

            // Lista principal donde guardaremos los libros
            List<Titulo> catalogo = new List<Titulo>();

            // --- LIBRO 1 (3 ejemplares) ---
            Titulo t1 = new Titulo();
            t1.Id = 1;
            t1.Nombre = "Don Quijote de la Mancha";
            t1.Autor = "Miguel de Cervantes";
            t1.ISBN = "978-8424922405";
            t1.PrestamosHistoricos = 15;

            Ejemplar e101 = new Ejemplar();
            e101.Id = 101;
            e101.CodigoBarras = "DQ-01";
            e101.Estado = "Disponible";
            t1.Ejemplares.Add(e101);

            Ejemplar e102 = new Ejemplar();
            e102.Id = 102;
            e102.CodigoBarras = "DQ-02";
            e102.Estado = "Disponible";
            t1.Ejemplares.Add(e102);

            Ejemplar e103 = new Ejemplar();
            e103.Id = 103;
            e103.CodigoBarras = "DQ-03";
            e103.Estado = "Disponible";
            t1.Ejemplares.Add(e103);

            catalogo.Add(t1);

            // --- LIBRO 2 (1 ejemplar) ---
            Titulo t2 = new Titulo();
            t2.Id = 2;
            t2.Nombre = "Cien Anos de Soledad";
            t2.Autor = "Gabriel Garcia Marquez";
            t2.ISBN = "978-0307474728";
            t2.PrestamosHistoricos = 28;

            Ejemplar e201 = new Ejemplar();
            e201.Id = 201;
            e201.CodigoBarras = "CS-01";
            e201.Estado = "Disponible";
            t2.Ejemplares.Add(e201);

            catalogo.Add(t2);

            // --- LIBRO 3 (5 ejemplares) ---
            Titulo t3 = new Titulo();
            t3.Id = 3;
            t3.Nombre = "El Principito";
            t3.Autor = "Antoine de Saint-Exupery";
            t3.ISBN = "978-0156013987";
            t3.PrestamosHistoricos = 42;

            Ejemplar e301 = new Ejemplar(); e301.Id = 301; e301.CodigoBarras = "EP-01"; e301.Estado = "Disponible"; t3.Ejemplares.Add(e301);
            Ejemplar e302 = new Ejemplar(); e302.Id = 302; e302.CodigoBarras = "EP-02"; e302.Estado = "Disponible"; t3.Ejemplares.Add(e302);
            Ejemplar e303 = new Ejemplar(); e303.Id = 303; e303.CodigoBarras = "EP-03"; e303.Estado = "Disponible"; t3.Ejemplares.Add(e303);
            Ejemplar e304 = new Ejemplar(); e304.Id = 304; e304.CodigoBarras = "EP-04"; e304.Estado = "Disponible"; t3.Ejemplares.Add(e304);
            Ejemplar e305 = new Ejemplar(); e305.Id = 305; e305.CodigoBarras = "EP-05"; e305.Estado = "Disponible"; t3.Ejemplares.Add(e305);

            catalogo.Add(t3);

            // --- LIBRO 4 (2 ejemplares) ---
            Titulo t4 = new Titulo();
            t4.Id = 4;
            t4.Nombre = "Fahrenheit 451";
            t4.Autor = "Ray Bradbury";
            t4.ISBN = "978-1451673319";
            t4.PrestamosHistoricos = 10;

            Ejemplar e401 = new Ejemplar(); e401.Id = 401; e401.CodigoBarras = "F4-01"; e401.Estado = "Disponible"; t4.Ejemplares.Add(e401);
            Ejemplar e402 = new Ejemplar(); e402.Id = 402; e402.CodigoBarras = "F4-02"; e402.Estado = "Disponible"; t4.Ejemplares.Add(e402);

            catalogo.Add(t4);

            // --- LIBRO 5 (4 ejemplares) ---
            Titulo t5 = new Titulo();
            t5.Id = 5;
            t5.Nombre = "1984";
            t5.Autor = "George Orwell";
            t5.ISBN = "978-0451524935";
            t5.PrestamosHistoricos = 35;

            Ejemplar e501 = new Ejemplar(); e501.Id = 501; e501.CodigoBarras = "19-01"; e501.Estado = "Disponible"; t5.Ejemplares.Add(e501);
            Ejemplar e502 = new Ejemplar(); e502.Id = 502; e502.CodigoBarras = "19-02"; e502.Estado = "Disponible"; t5.Ejemplares.Add(e502);
            Ejemplar e503 = new Ejemplar(); e503.Id = 503; e503.CodigoBarras = "19-03"; e503.Estado = "Disponible"; t5.Ejemplares.Add(e503);
            Ejemplar e504 = new Ejemplar(); e504.Id = 504; e504.CodigoBarras = "19-04"; e504.Estado = "Disponible"; t5.Ejemplares.Add(e504);

            catalogo.Add(t5);

            // --- LIBRO 6 (1 ejemplar) ---
            Titulo t6 = new Titulo();
            t6.Id = 6;
            t6.Nombre = "Pedro Paramo";
            t6.Autor = "Juan Rulfo";
            t6.ISBN = "978-8437604183";
            t6.PrestamosHistoricos = 8;

            Ejemplar e601 = new Ejemplar(); e601.Id = 601; e601.CodigoBarras = "PP-01"; e601.Estado = "Disponible"; t6.Ejemplares.Add(e601);

            catalogo.Add(t6);

            // --- LIBRO 7 (3 ejemplares) ---
            Titulo t7 = new Titulo();
            t7.Id = 7;
            t7.Nombre = "Rayuela";
            t7.Autor = "Julio Cortazar";
            t7.ISBN = "978-8437604572";
            t7.PrestamosHistoricos = 15;

            Ejemplar e701 = new Ejemplar(); e701.Id = 701; e701.CodigoBarras = "RY-01"; e701.Estado = "Disponible"; t7.Ejemplares.Add(e701);
            Ejemplar e702 = new Ejemplar(); e702.Id = 702; e702.CodigoBarras = "RY-02"; e702.Estado = "Disponible"; t7.Ejemplares.Add(e702);
            Ejemplar e703 = new Ejemplar(); e703.Id = 703; e703.CodigoBarras = "RY-03"; e703.Estado = "Disponible"; t7.Ejemplares.Add(e703);

            catalogo.Add(t7);

            // --- LIBRO 8 (2 ejemplares) ---
            Titulo t8 = new Titulo();
            t8.Id = 8;
            t8.Nombre = "La Metamorfosis";
            t8.Autor = "Franz Kafka";
            t8.ISBN = "978-8420651361";
            t8.PrestamosHistoricos = 20;

            Ejemplar e801 = new Ejemplar(); e801.Id = 801; e801.CodigoBarras = "LM-01"; e801.Estado = "Disponible"; t8.Ejemplares.Add(e801);
            Ejemplar e802 = new Ejemplar(); e802.Id = 802; e802.CodigoBarras = "LM-02"; e802.Estado = "Disponible"; t8.Ejemplares.Add(e802);

            catalogo.Add(t8);

            // --- MOSTRAR DATOS EN CONSOLA ---
            Console.WriteLine("Total de libros cargados: " + catalogo.Count);
            Console.WriteLine("---------------------------------------------");

            foreach (Titulo libro in catalogo)
            {
                Console.WriteLine("ID: " + libro.Id);
                Console.WriteLine("Titulo: " + libro.Nombre);
                Console.WriteLine("ISBN: " + libro.ISBN);
                Console.WriteLine("Prestamos: " + libro.PrestamosHistoricos);
                Console.WriteLine("Cantidad de Ejemplares: " + libro.Ejemplares.Count);
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}
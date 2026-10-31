using System.Collections.Generic;

namespace BibliotecaEscolar.Models
{
    public class Titulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int PrestamosHistoricos { get; set; }
        
        // Creamos la lista directamente
        public List<Ejemplar> Ejemplares { get; set; } = new List<Ejemplar>();
    }
}
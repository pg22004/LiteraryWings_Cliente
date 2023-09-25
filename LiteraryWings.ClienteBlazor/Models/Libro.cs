using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LiteraryWings.ClienteBlazor.Models
{
    public class Libro
    {

        public int Id { get; set; }
        public int IdAutor { get; set; }
        public int IdCategoria { get; set; }
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }
        public string FechaLanzamiento { get; set; }
        public string Idioma { get; set; }
        public int Paginas { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }
        public string ImagenPortada { get; set; }
        public string LinkDescarga { get; set; }
        public string ImagenIntroduccion { get; set; }

    }
}

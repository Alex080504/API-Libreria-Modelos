using System.ComponentModel.DataAnnotations;

namespace Libreria.Modelos
{
    public class Libro
    {
        [Key]public int Id { get; set; }
        public string Titulo { get; set; }
        public int CantidadPaginas { get; set; }
        public int CantidadEjemplares { get; set; }
        public string Genero { get; set; }
        public int AnioPublicacion { get; set; }

        //Foreign Key
        public int IdEditorial { get; set; }
        public int IdAutor { get; set; }
        public int IdPais { get; set; }

        //Navigation Properties
        public Editorial? Editorial { get; set; }
        public Autor? Autor { get; set; }
        public Pais? Pais { get; set; }
    }
}

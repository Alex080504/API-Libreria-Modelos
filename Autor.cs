using System.ComponentModel.DataAnnotations;

namespace Libreria.Modelos
{
    public class Autor
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //Foreign Key
        public int IdPais { get; set; }

        //Navigation properties
        public List<Libro>? Libros { get; set; }
        public Pais? Pais { get; set; }
    }
}

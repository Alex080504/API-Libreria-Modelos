using System.ComponentModel.DataAnnotations;

namespace Libreria.Modelos
{
    public class Editorial
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; }
        
        //Foreign Key
        public int IdPais { get; set; }

        //Navigation properties
        public List<Libro>? Libros { get; set; }
        public Pais? Pais { get; set; }

    }
}

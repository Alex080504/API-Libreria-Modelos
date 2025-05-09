namespace Libreria.Modelos
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Continente { get; set; }
        public string Idioma { get; set; }
        public string Moneda { get; set; }
        public string Capital { get; set; }
        public List<Autor>? Autores { get; set; }
        public List<Editorial>? Editoriales { get; set; }
        public List<Libro>? Libros { get; set; }
    }
}

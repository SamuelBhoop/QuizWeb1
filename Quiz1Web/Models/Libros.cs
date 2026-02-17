using System.ComponentModel.DataAnnotations;

namespace Quiz1Web.Models
{
    public class Libros
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del libro")]
        [MinLength(2, ErrorMessage = "La cantidad mínima es 1")]

        public String Nombre { get; set; }
        public String Autor { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

    }
}

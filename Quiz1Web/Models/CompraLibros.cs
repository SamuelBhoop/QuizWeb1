using System.ComponentModel.DataAnnotations;

namespace Quiz1Web.Models
{
    public class CompraLibros
    {
        public int ID { get; set; }
        public string NombreComprador { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre de compra")]
        [MinLength(2, ErrorMessage = "La cantidad mínima es 1")]
        public int StockAComprar {  get; set; }
        public int PrecioDeCompra { get; set; }
    }
}

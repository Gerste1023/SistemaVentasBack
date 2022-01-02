using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBackCasa.Domain.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Referencia { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Marca { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string Salida { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Descripcion { get; set; }
        [Required]
        public int Descuento { get; set; }
    }
}

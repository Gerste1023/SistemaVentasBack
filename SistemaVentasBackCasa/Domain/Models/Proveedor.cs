using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBackCasa.Domain.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string Nit { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "varchar(13)")]
        public string Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        
    }
}

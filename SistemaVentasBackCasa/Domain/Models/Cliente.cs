using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBackCasa.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string Rut { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(13)")]
        public string Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Ciudad { get; set; }
        public string Observacion { get; set; }
        
    }
}

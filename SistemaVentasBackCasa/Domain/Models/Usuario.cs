using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentasBackCasa.Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string Identificacion { get; set; }
        [Required]
        [Column(TypeName ="varchar(30)")]
        public string Nombres { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Apellidos { get; set; }
        [Required]
        [Column(TypeName = "varchar(13)")]
        public string Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Direccion { get; set; }
        public string FotoUrl { get; set; }
        [Required]
        public int RolId { get; set; }
    }
}


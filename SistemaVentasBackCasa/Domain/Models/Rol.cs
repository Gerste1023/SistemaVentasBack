using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.Models
{
    public class Rol
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar(30)")]
        public string TipoRol { get; set; }
    }
}

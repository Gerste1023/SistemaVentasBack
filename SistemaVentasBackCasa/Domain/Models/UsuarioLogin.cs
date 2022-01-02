using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.Models
{
    public class UsuarioLogin
    {
        [Required]
        public string Identificacion { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

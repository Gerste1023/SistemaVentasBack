using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IServices
{
    public interface ILoginService
    {
        Task<Usuario> ValidarUsuario(UsuarioLogin usuario);
    }
}

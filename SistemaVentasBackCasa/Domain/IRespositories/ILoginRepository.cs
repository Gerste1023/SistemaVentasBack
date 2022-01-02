using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IRespositories
{
    public interface ILoginRepository
    {
        Task<Usuario> ValidarUsuario(UsuarioLogin usuario);
    }
}

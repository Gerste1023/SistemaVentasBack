using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IServices
{
    public interface IUsuarioService
    {
        Task GuardarUsuario(Usuario usuario);
        Task<bool> ValidarExistencia(Usuario usuario);
        Task<Usuario> ValidarPassword(int idUsuario, string passwordAnterior);
        Task ActualizarPassword(Usuario usuario);
    }
}

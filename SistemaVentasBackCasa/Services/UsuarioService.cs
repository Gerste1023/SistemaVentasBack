using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task GuardarUsuario(Usuario usuario)
        {
            await _usuarioRepository.GuardarUsuario(usuario);
        }
        public async Task<bool> ValidarExistencia(Usuario usuario)
        {
            return await _usuarioRepository.ValidarExistencia(usuario);
        }
        public async Task<Usuario> ValidarPassword(int idUsuario, string passwordAnterior)
        {
            return await _usuarioRepository.ValidarPassword(idUsuario, passwordAnterior);
        }
        public async Task ActualizarPassword(Usuario usuario)
        {
            await _usuarioRepository.ActualizarPassword(usuario);
        }
    }
}

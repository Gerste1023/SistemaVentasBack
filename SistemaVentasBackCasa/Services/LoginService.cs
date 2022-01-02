using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Services
{
    public class LoginService: ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<Usuario> ValidarUsuario(UsuarioLogin usuario)
        {
            return await _loginRepository.ValidarUsuario(usuario);
        }
    }
}

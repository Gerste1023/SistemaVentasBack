using Microsoft.EntityFrameworkCore;
using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Persistence.Context;
using SistemaVentasBackCasa.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Persistence.Repositories
{
    public class LoginRepository: ILoginRepository
    {
        private readonly AplicationDbContext _context;
        public LoginRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Usuario> ValidarUsuario(UsuarioLogin usuario)
        {
            var user = await _context.Usuarios.Where(x => x.Identificacion == usuario.Identificacion && x.Password == usuario.Password).FirstOrDefaultAsync();
            return user;
        }
    }
}

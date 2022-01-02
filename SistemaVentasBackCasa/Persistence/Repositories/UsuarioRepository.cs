using Microsoft.EntityFrameworkCore;
using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.Models;
using SistemaVentasBackCasa.Persistence.Context;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Persistence.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly AplicationDbContext _context;
        public UsuarioRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task GuardarUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ValidarExistencia(Usuario usuario)
        {
            var validarExistencia = await _context.Usuarios.AnyAsync(x => x.Identificacion == usuario.Identificacion);
            return validarExistencia;
        } 
        public async Task<Usuario> ValidarPassword(int idUsuario, string passwordAnterior)
        {
            var usuario = await _context.Usuarios.Where(x => x.Identificacion == idUsuario.ToString() && x.Password == passwordAnterior).FirstOrDefaultAsync();
            return usuario;
        }
        public async Task ActualizarPassword(Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
        }
    }
}

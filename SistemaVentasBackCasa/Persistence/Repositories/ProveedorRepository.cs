using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.Models;
using SistemaVentasBackCasa.Persistence.Context;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Persistence.Repositories
{
    public class ProveedorRepository: IProveedorRepository
    {
        private readonly AplicationDbContext _context;
        public ProveedorRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task GuardarProveedor(Proveedor proveedor)
        {
            _context.Add(proveedor);
            await _context.SaveChangesAsync();
        }
    }
}

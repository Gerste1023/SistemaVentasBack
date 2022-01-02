using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.Models;
using SistemaVentasBackCasa.Persistence.Context;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Persistence.Repositories
{
    public class ProductoRepository: IProductoRepository
    {
        private readonly AplicationDbContext _context;
        public ProductoRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task GuardarProducto(Producto producto)
        {
            _context.Add(producto);
            await _context.SaveChangesAsync();
        }
    }
}

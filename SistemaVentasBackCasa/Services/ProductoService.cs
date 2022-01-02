using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Services
{
    public class ProductoService: IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public async Task GuardarProducto(Producto producto)
        {
            await _productoRepository.GuardarProducto(producto);
        }
    }
}

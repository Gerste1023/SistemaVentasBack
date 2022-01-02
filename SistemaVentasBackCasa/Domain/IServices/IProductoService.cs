using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IServices
{
    public interface IProductoService
    {
        Task GuardarProducto(Producto producto);
    }
}

using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IRespositories
{
    public interface IProductoRepository
    {
        Task GuardarProducto(Producto producto);
    }
}

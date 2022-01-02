using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IServices
{
    public interface IProveedorService
    {
        Task GuardarProveedor(Proveedor proveedor);
    }
}

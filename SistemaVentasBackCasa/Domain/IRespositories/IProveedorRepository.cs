using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IRespositories
{
    public interface IProveedorRepository
    {
        Task GuardarProveedor(Proveedor proveedor);
    }
}

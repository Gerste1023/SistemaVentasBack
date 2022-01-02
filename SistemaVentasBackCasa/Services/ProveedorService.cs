using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Services
{
    public class ProveedorService: IProveedorService
    {
        private readonly IProveedorRepository _proveedorRepository;
        public ProveedorService(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }
        public async Task GuardarProveedor(Proveedor proveedor)
        {
            await _proveedorRepository.GuardarProveedor(proveedor);
        }
    }
}

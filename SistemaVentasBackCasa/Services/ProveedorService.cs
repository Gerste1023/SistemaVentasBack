using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
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
        public async Task AgregarProveedor(Proveedor proveedor)
        {
            await _proveedorRepository.AgregarProveedor(proveedor);
        }
        public async Task<List<Proveedor>> ListarProveedor()
        {
            return await _proveedorRepository.ListarProveedor();
        }
        public async Task<Proveedor> ListarProveedorPorId(int idProveedor)
        {
            return await _proveedorRepository.ListarProveedorPorId(idProveedor);
        }
        public async Task EliminarProveedor(int idProveedor)
        {
            await _proveedorRepository.EliminarProveedor(idProveedor);
        }
        public async Task EditarProveedor(Proveedor proveedor)
        {
            await _proveedorRepository.EditarProveedor(proveedor);
        }
    }
}

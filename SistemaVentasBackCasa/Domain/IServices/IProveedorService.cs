using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IServices
{
    public interface IProveedorService
    {
        Task AgregarProveedor(Proveedor proveedor);
        Task<List<Proveedor>> ListarProveedor();
        Task<Proveedor> ListarProveedorPorId(int idProveedor);
        Task EliminarProveedor(int idProveedor);
        Task EditarProveedor(Proveedor proveedor);
    }
}

using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IRespositories
{
    public interface IProveedorRepository
    {
        Task AgregarProveedor(Proveedor proveedor);
        Task<List<Proveedor>> ListarProveedor();
        Task<Proveedor> ListarProveedorPorId(int idProveedor);
        Task EliminarProveedor(int idProveedor);
        Task EditarProveedor(Proveedor proveedor);
    }
}

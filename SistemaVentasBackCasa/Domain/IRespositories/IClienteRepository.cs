using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IRespositories
{
    public interface IClienteRepository
    {
        Task AgregarCliente(Cliente cliente);
        Task<List<Cliente>> ListarCliente();
        Task<Cliente> ListarClientePorId(int idCliente);
        Task EliminarCliente(int idCliente);
        Task EditarCliente(Cliente cliente);
    }
}

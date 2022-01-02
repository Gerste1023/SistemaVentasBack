using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IServices
{
    public interface IClienteService
    {
        Task AgregarCliente(Cliente cliente);
        Task<List<Cliente>> ListarCliente();
        Task<Cliente> ListarClientePorId(int idCliente);
        Task EliminarCliente(int idCliente);
        Task EditarCliente(Cliente cliente);
    }
}

using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Services
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task AgregarCliente(Cliente cliente)
        {
            await _clienteRepository.AgregarCliente(cliente);
        }
        public async Task<List<Cliente>> ListarCliente()
        {
            return await _clienteRepository.ListarCliente();
        }
        public async Task<Cliente> ListarClientePorId(int idCLiente)
        {
            return await _clienteRepository.ListarClientePorId(idCLiente);
        }
        public async Task EliminarCliente(int idCliente)
        {
            await _clienteRepository.EliminarCliente(idCliente);
        }
        public async Task EditarCliente(Cliente cliente)
        {
            await _clienteRepository.EditarCliente(cliente);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.Models;
using SistemaVentasBackCasa.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Persistence.Repositories
{
    public class ClienteRepository: IClienteRepository
    {
        private readonly AplicationDbContext _context;
        public ClienteRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task AgregarCliente(Cliente cliente)
        {
            _context.Add(cliente);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Cliente>> ListarCliente()
        {
            var listClientes = await _context.Clientes.ToListAsync();
            return listClientes;
        }
        public async Task<Cliente> ListarClientePorId(int idCliente)
        {
            var cliente = await _context.Clientes.Where(x => x.Id == idCliente).FirstOrDefaultAsync();
            return cliente;
        }
        public async Task EliminarCliente(int idCliente)
        {
            var cliente = await _context.Clientes.FindAsync(idCliente);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }
        public async Task EditarCliente(Cliente cliente)
        {
            _context.Update(cliente);
            await _context.SaveChangesAsync();
        }
    }
}

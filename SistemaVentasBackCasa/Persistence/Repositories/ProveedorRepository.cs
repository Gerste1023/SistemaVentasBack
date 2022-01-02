using Microsoft.EntityFrameworkCore;
using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.Models;
using SistemaVentasBackCasa.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Persistence.Repositories
{
    public class ProveedorRepository: IProveedorRepository
    {
        private readonly AplicationDbContext _context;
        public ProveedorRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task AgregarProveedor(Proveedor proveedor)
        {
            _context.Add(proveedor);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Proveedor>> ListarProveedor()
        {
            var listProveedores = await _context.Proveedores.ToListAsync();

            return listProveedores;
        }
        public async Task<Proveedor> ListarProveedorPorId(int idProveedor)
        {
            var proveedor = await _context.Proveedores.Where(x => x.Id == idProveedor).FirstOrDefaultAsync();
            return proveedor;
        }
        public async Task EliminarProveedor(int idProveedor)
        {
            var proveedor = await _context.Proveedores.FindAsync(idProveedor);
            _context.Proveedores.Remove(proveedor);
            await _context.SaveChangesAsync();
        }
        public async Task EditarProveedor(Proveedor proveedor)
        {
            _context.Update(proveedor);
            await _context.SaveChangesAsync();
        }
    }
}

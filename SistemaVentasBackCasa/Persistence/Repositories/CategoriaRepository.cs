using Microsoft.EntityFrameworkCore;
using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.Models;
using SistemaVentasBackCasa.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Persistence.Repositories
{
    public class CategoriaRepository: ICategoriaRepository
    {
        private readonly AplicationDbContext _context;
        public CategoriaRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task AgregarCategoria(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Categoria>> ListarCategoria()
        {
            var listCategorias = await _context.Categorias.ToListAsync();

            return listCategorias;
        }
        public async Task<Categoria> ListarCategoriaPorId(int idCategoria)
        {
            var categoria = await _context.Categorias.Where(x => x.Id == idCategoria).FirstOrDefaultAsync();
            return categoria;
        }
        public async Task EliminarCategoria(int idCategoria)
        {
            var categoria = await _context.Categorias.FindAsync(idCategoria);
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
        }
        public async Task EditarCategoria(Categoria categoria)
        {
            _context.Update(categoria);
            await _context.SaveChangesAsync();
        }
    }
}

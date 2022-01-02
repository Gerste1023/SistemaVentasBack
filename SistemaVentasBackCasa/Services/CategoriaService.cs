using SistemaVentasBackCasa.Domain.IRespositories;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Services
{
    public class CategoriaService: ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task AgregarCategoria(Categoria categoria)
        {
            await _categoriaRepository.AgregarCategoria(categoria);
        }
        public async Task<List<Categoria>> ListarCategoria()
        {
            return await _categoriaRepository.ListarCategoria();
        }
        public async Task<Categoria> ListarCategoriaPorId(int idCategoria)
        {
            return await _categoriaRepository.ListarCategoriaPorId(idCategoria);
        }
        public async Task EliminarCategoria(int idCategoria)
        {
            await _categoriaRepository.EliminarCategoria(idCategoria);
        }
        public async Task EditarCategoria(Categoria categoria)
        {
            await _categoriaRepository.EditarCategoria(categoria);
        }
    }
}

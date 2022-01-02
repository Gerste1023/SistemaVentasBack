using SistemaVentasBackCasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaVentasBackCasa.Domain.IServices
{
    public interface ICategoriaService
    {
        Task AgregarCategoria(Categoria categoria);
        Task<List<Categoria>> ListarCategoria();
        Task<Categoria> ListarCategoriaPorId(int idCategoria);
        Task EliminarCategoria(int idCategoria);
        Task EditarCategoria(Categoria categoria);
    }
}

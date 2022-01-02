using Microsoft.EntityFrameworkCore;
using SistemaVentasBackCasa.Domain.Models;

namespace SistemaVentasBackCasa.Persistence.Context
{
    public class AplicationDbContext: DbContext
    {
        //agregar todas las demas tablas
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Rol>Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        //DbSet<Venta> Ventas { get; set; }

        public AplicationDbContext( DbContextOptions<AplicationDbContext> options ): base(options)
        {

        }
    }
}

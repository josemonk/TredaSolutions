using Microsoft.EntityFrameworkCore;
using TredaSolutions.Domains.Models;

namespace TredaSolutions.Persitence.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {    
        }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Tienda> tiendas { get; set; }
    }
}

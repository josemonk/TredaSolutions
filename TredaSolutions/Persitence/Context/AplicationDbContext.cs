using Microsoft.EntityFrameworkCore;

namespace TredaSolutions.Persitence.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}

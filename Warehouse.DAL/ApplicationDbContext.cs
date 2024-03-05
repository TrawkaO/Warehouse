using Microsoft.EntityFrameworkCore;
using Warehouse.Domain.Entity;

namespace Warehouse.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Car> Car { get; set; }
    }
}
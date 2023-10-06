using Microsoft.EntityFrameworkCore;

namespace Bil_udlejning.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Renting> Rentings { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}

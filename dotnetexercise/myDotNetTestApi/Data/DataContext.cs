using Microsoft.EntityFrameworkCore;

namespace myDotNetTestApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Company> Companies { get; set; }
    }
}

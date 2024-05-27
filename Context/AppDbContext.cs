using Microsoft.EntityFrameworkCore;
using Net_8_backend.Models;

namespace Net_8_backend.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Net_8_backend.Models.Person> Person { get; set; } = default!;

    }
}

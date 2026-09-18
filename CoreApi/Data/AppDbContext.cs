using Microsoft.EntityFrameworkCore;

namespace CoreApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Measurement> Measurements { get; set; }
}
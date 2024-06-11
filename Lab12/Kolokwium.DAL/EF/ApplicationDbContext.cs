using Kolokwium.Model;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.DAL.EF;
public class ApplicationDbContext : DbContext
{
    public DbSet<Park> Parks { get; set; } = null!;
    public DbSet<Tree> Trees { get; set; } = null!;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

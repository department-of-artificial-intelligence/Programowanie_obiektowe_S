using Kolokwium.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.DAL.EF;
public class ApplicationDbContext : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Grade> Grades { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

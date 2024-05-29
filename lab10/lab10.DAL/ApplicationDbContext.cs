using lab10.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace lab10.DAL;
public class ApplicationDbContext : DbContext
{
    public virtual DbSet<Grade> Grades { get; set; } = null!;
    public virtual DbSet<Student> Students { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }
}
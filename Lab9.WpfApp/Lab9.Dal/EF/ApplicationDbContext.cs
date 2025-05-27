using Lab9.Model.Entities;
using Microsoft.EntityFrameworkCore;
namespace Lab9.DAL.EF; 
public class ApplicationDbContext : DbContext 
{ 
    public virtual DbSet<Grade> Grades { get; set; } = null!; 
    public virtual DbSet<Student> Students { get; set; } = null!; 
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 
}
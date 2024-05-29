using Lab10.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab10.DAL
{
    public class MSContext : DbContext
    {
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public MSContext(DbContextOptions<MSContext> options) : base(options) { }
    }
}

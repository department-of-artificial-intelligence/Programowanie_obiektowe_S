using Lab10.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.DAL.EF
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Grade> Grades { get; set; } = null!; public virtual DbSet<Student> Students { get; set; } = null!;
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Vlad_Dzhuha_PO_AppDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}

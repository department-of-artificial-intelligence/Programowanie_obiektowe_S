using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11.Model;
using Lab11.Model.Entities;
using Microsoft.EntityFrameworkCore;
namespace Lab11.DAL.EF;

public class ApplicationDbContext : DbContext
{
    public virtual DbSet<Grade> Grades { get; set; } = null!;
    public virtual DbSet<Student> Students { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab10_2.Model.Entities;
using Microsoft.EntityFrameworkCore;
namespace Lab10_2.DAL.EF;
public class ApplicationDbContext : DbContext
{
	public virtual DbSet<Grade> Grades { get; set; } = null!;
	public virtual DbSet<Student> Students { get; set; } = null!;
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	: base(options)
	{
	}
}


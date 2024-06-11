using Kolokwium.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.DAL.EF;
public class ApplicationDbContext : DbContext
{
    public virtual DbSet<Parking> Parkings { get; set; } = null!;
	public virtual DbSet<Car> Cars { get; set; } = null!;
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

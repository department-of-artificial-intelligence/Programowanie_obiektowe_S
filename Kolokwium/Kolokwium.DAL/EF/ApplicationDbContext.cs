using Microsoft.EntityFrameworkCore;

namespace Kolokwium.DAL.EF;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

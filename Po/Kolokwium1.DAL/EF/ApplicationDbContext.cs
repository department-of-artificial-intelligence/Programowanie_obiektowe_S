using Kolokwium1.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1.DAL.EF
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
    }
}

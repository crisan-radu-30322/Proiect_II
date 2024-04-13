using ProiectII.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ProiectII.Data
{
    public class ProiectIIDbContext : DbContext
    {
        public ProiectIIDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}

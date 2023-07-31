using Auth.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auth.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Magazin> Magazins { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;uid=root;pwd=12345;database=test",
                ServerVersion.AutoDetect("server=127.0.0.1;uid=root;pwd=12345;database=test"));
        }
    }
}

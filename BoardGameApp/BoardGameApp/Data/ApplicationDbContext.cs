using BoardGameApp.Data.Domains;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardGameApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<BoardGame> BoardGames { get; set; } = null!;
        public DbSet<BoardGamesSeller> BoardGamesSellers { get; set; } = null!;
        public DbSet<Creator> Creators { get; set; } = null!;
        public DbSet<Seller> Sellers { get; set; } = null!;
    }
}

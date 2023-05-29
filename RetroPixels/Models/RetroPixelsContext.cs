using Microsoft.EntityFrameworkCore;

namespace RetroPixels.Models
{
    public class RetroPixelsContext : DbContext
    {
        public RetroPixelsContext() { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameDetail> GameDetails { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                   @"Data Source=.\SQLEXPRESS;Initial Catalog=RetroPixels;Integrated Security=True;TrustServerCertificate=true;",
                   providerOptions => { providerOptions.EnableRetryOnFailure(); });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasOne(a => a.GameDetail)
                .WithOne(b => b.Game)
                .HasForeignKey<GameDetail>(b => b.GameId);
        }

    }
}

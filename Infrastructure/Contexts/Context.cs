using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class Context : DbContext
    {
        public virtual DbSet<Album> Albums { get; set; }

        public virtual DbSet<Artiste> Artiste { get; set; }

        public virtual DbSet<Music> Music { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new ArtisteConfiguration());
            modelBuilder.ApplyConfiguration(new MusicConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Music;User Id=root;Password=123456;Trusted_Connection=True;");
        }
    }
}

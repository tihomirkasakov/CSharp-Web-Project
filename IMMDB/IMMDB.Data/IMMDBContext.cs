using IMMDB.Models;
using Microsoft.EntityFrameworkCore;

namespace IMMDB.Data
{
    public class IMMDBContext : DbContext
    {
        public DbSet<Director> Directors { get; set; }

        public DbSet<DirectorShow> DirectorShows { get; set; }

        public DbSet<Episode> Episodes { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<GenreShow> GenreShows { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Serie> Series { get; set; }

        public DbSet<Show> Shows { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Data Source=.;DataBase= Movie Matchmaker; Integrated Security= True;");
            }

            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<DirectorShow>()
                .HasKey(ds => new { ds.DirectorId, ds.ShowId });

            model.Entity<Director>()
                .HasMany(s => s.Shows)
                .WithOne(d => d.Director)
                .HasForeignKey(d => d.DirectorId);

            model.Entity<Show>()
                .HasMany(d => d.Directors)
                .WithOne(s => s.Show)
                .HasForeignKey(s => s.ShowId);

            model.Entity<GenreShow>()
                .HasKey(gs => new { gs.GenreId, gs.ShowId });

            model.Entity<Genre>()
                .HasMany(s => s.Shows)
                .WithOne(g => g.Genre)
                .HasForeignKey(g => g.GenreId);

            model.Entity<Show>()
                .HasMany(g => g.Genres)
                .WithOne(s => s.Show)
                .HasForeignKey(s => s.ShowId);

            base.OnModelCreating(model);
        }
    }
}

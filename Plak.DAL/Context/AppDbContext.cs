using Microsoft.EntityFrameworkCore;
using Plak.DAL.Configurations;
using Plak.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-EVCENE1; Initial Catalog = PlakDb; User Id = sa; Password = Anyela123");
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new AlbumConfiguration().Configure(modelBuilder.Entity<Album>());
            new ArtistConfiguration().Configure(modelBuilder.Entity<Artist>());

            //base.OnModelCreating(modelBuilder);
        }
    }
}

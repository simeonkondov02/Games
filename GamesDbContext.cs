using GamesClassLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class GamesDbContext : DbContext
    {
        public GamesDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder opBuilder)
        {
            opBuilder.UseSqlServer("server=ELDERS-CONFEREN\\SQLEXPRESS;database=myEFCoreDB;trusted_connection=true;TrustServerCertificate=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasKey(i => i.Id);
            modelBuilder.Entity<Game>().Property(n => n.Name).IsRequired();
            modelBuilder.Entity<Game>().HasMany(g => g.Tags).WithMany(g => g.Games);
            modelBuilder.Entity<Game>().HasOne<Genre>().WithMany(x => x.Games);

            modelBuilder.Entity<Genre>().HasKey(i => i.Id);
            modelBuilder.Entity<Genre>().Property(n => n.Name).IsRequired();
            modelBuilder.Entity<Genre>().HasMany(x => x.Games).WithOne(x => x.Genre);

            modelBuilder.Entity<Tag>().HasKey(i => i.Id);
            modelBuilder.Entity<Tag>().Property(n => n.Name).IsRequired();
            modelBuilder.Entity<Tag>().HasMany<Game>().WithMany(t => t.Tags);
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}

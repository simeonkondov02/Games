using Microsoft.EntityFrameworkCore;
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

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}

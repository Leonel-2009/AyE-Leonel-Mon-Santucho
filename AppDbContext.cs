using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Simulacro
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Jugadores> goleadores_mundial => Set<Jugadores>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Port=3307;Database=simulacro;Uid=root;pwd=;";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

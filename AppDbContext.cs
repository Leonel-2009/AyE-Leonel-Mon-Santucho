using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp4
{
    public class Productos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public double Precio { get; set; }
    }

    internal class AppDbContext : DbContext
    {
        public DbSet<Productos> Productos => Set<Productos>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Port=3307;Database=tp_n23;Uid=root;pwd=;";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}

using Microsoft.EntityFrameworkCore;

namespace Crud22.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud22;Integrated Security=True");
        }
    }
}

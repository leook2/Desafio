using Microsoft.EntityFrameworkCore;
using Desafio.Model;

namespace Desafio.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Despesa> Despesas {get; set;}
        public DbSet<Inquilino> Inquilinos {get; set;}
        public DbSet<Unidade> Unidades {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString:"DataSource=app.db;Cache=Shared");
        }    
    }
}
using ConsoleApp29.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp29.Context
{
    public class CountryDbContext : DbContext
    {
        public DbSet<Presindent> Presindents { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0116-01;Initial Catalog = CountryDb ;User ID=admin;Password = admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

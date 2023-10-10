using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CleanArchitecture.Infrastructure.Data
{
    public class DbAppContext : DbContext
    {
       
        public DbSet<UserEntity> Users { get; set; }

        public DbAppContext()
        {
           Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CleanArchitecture;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    




    }
}

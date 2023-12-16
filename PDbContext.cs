using AssessmentRest.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRest
{
    public class PDbContext : DbContext
    {


        public PDbContext()
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-6P5NK25R\SQLSERVER2022DEV;Database=EFCoreDB1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        }
       
        public DbSet<User> users { get; set; }
        public DbSet<Order> orders { get; set; }

        public DbSet<Product> products { get; set; }
        
    }
}

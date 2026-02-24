using Delivery.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Delivers> delivers { get; set; }
        public DbSet<Packages> packages { get; set; }
        public DbSet<Recipients> recipients { get; set; }
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=School");
        }
    }
}


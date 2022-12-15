using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Entity_Freamwork
{
    public class ReCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Persist Security Info=False;User ID=yusuf;Initial Catalog=ReCarData;Data Source=yusufkc81;password=1");
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Rental> Rentals { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImages> CarImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
    }
}

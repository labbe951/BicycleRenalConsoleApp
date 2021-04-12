using BicycleRental.Configurations;
using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental
{
    public class BicycleRentalDbContext : DbContext
    {
        public BicycleRentalDbContext()
        {
        }

        public BicycleRentalDbContext(DbContextOptions<BicycleRentalDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking_detail> Booking_details { get; set; }
        public DbSet<Bicycle_brand> Bicycle_brands { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<DatabaseOwner> DatabaseOwners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server = (localdb)\MSSQLLocalDB;Database=BicycleRental;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new Bicycle_brand_config());
            modelBuilder
                .ApplyConfiguration(new Bicycle_config());
            modelBuilder
                .ApplyConfiguration(new Booking_detail_config());
            modelBuilder
                .ApplyConfiguration(new Customer_config());
            modelBuilder
                .ApplyConfiguration(new DatabaseOwner_config());

        }

    }
}

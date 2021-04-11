using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.Configurations
{
    class Booking_detail_config : IEntityTypeConfiguration<Booking_detail>
    {
        public void Configure(EntityTypeBuilder<Booking_detail> builder)
        {
            builder
                .HasKey(b => b.Booking_id);
            // Dessa builders gör en många till många relation till två stycken en till många relationer.
            builder
                .HasOne(b => b.Customer)
                .WithMany(c => c.Booking_details)
                .HasForeignKey(c => c.Customer_id);

            builder
                .HasOne(b => b.Bicycle)
                .WithMany(b => b.Booking_Details)
                .HasForeignKey(b => b.Bicycle_id);


        }
    }
}

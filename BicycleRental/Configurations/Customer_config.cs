using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Configurations
{
    class Customer_config : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(c => c.Customer_id);
            builder
                .HasMany(c => c.Booking_details)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.Customer_id);
            builder
                .Property(c => c.Phone_number).HasColumnType("BigInt");
                
        }
    }
}

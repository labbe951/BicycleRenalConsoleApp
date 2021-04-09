using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Configurations
{
    class Bicycle_config : IEntityTypeConfiguration<Bicycle>
    {
        public void Configure(EntityTypeBuilder<Bicycle> builder)
        {
            builder
                .HasKey(b => b.Bicycle_id);
            builder
                .HasMany(b => b.Booking_Details)
                .WithOne(b => b.Bicycle)
                .HasForeignKey(b => b.Bicycle_id);
        }
    }
}

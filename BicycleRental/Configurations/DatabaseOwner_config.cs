using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Configurations
{
    class DatabaseOwner_config : IEntityTypeConfiguration<DatabaseOwner>
    {
        public void Configure(EntityTypeBuilder<DatabaseOwner> builder)
        {
            builder
                .HasKey(x => x.OwnersFirstName);
        }
    }
}

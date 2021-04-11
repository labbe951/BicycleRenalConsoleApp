using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.Configurations
{
    class Bicycle_brand_config : IEntityTypeConfiguration<Bicycle_brand>
    {
        public void Configure(EntityTypeBuilder<Bicycle_brand> builder)
        {
            // Configurationen förklarar relationen mellan tabellerna och ger den nycklar.
            // Detta sätter Brand_id till primary key
            builder
                .HasKey(b => b.Brand_id);

            builder
                .HasMany(b => b.Bicycles)
                .WithOne(b => b.Bicycle_brand)
                .HasForeignKey(b => b.Brand_id);

        }
    }
}

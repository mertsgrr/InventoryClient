using InventoryClient.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryClient.Configurations
{
    internal class DataConfiguration : IEntityTypeConfiguration<Data>
    {
        public void Configure(EntityTypeBuilder<Data> builder)
        {
            builder.
                HasKey(x => x.Id);

            builder.Property(x => x.Version)
                .IsRequired();

            builder.Property(x => x.VersionName)
                .IsRequired();
            
            builder.Property(x => x.ReleaseDate)
                .IsRequired();

            builder.Property(x => x.CurrentRelease)
                .IsRequired();
        }
    }
}

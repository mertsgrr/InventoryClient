using InventoryClient.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClient.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Name)
                .HasMaxLength(50);

            builder.Property(u => u.Surname)
                .HasMaxLength(50);

            builder.Property(u => u.IsActive)
                .IsRequired();

            builder.Property(u => u.IsAdmin)
                .IsRequired();

        }
    }
}

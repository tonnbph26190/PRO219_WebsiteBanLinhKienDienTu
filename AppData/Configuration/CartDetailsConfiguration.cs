﻿using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AppData.Configuration
{
    public class CartDetailsConfiguration : IEntityTypeConfiguration<CartDetailsEntity>
    {
        public void Configure(EntityTypeBuilder<CartDetailsEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(cd => cd.Carts)
                .WithMany(c => c.CartDetails)
                .HasForeignKey(cd => cd.CartId);

        }
    }
}

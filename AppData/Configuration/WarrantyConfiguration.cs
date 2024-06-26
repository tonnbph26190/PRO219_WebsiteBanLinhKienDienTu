﻿using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AppData.Configuration
{
    public class WarrantyConfiguration : IEntityTypeConfiguration<WarrantyEntity>
    {
        public void Configure(EntityTypeBuilder<WarrantyEntity> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

﻿using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AppData.Configuration
{
    public class BillDetailsConfiguration : IEntityTypeConfiguration<BillDetailsEntity>
    {
        public void Configure(EntityTypeBuilder<BillDetailsEntity> builder)
        {
            builder.HasKey(p => p.Id);


            builder.HasOne(p => p.Discounts).WithMany().HasForeignKey(p => p.IdDiscount);

            builder.HasOne(p => p.Bills).WithMany().HasForeignKey(p => p.IdBill);
        }
    }
}

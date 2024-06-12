using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Configuration
{
    public class SaleConfiguration : IEntityTypeConfiguration<SalesEntity>
    {
        public void Configure(EntityTypeBuilder<SalesEntity> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

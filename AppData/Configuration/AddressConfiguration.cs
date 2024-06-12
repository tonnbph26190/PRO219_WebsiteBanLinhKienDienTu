using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppData.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Accounts).WithMany().HasForeignKey(p => p.IdAccount);
        }
    }
}

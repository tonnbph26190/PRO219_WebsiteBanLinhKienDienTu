using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AppData.Configuration
{
    public class RankConfiguration : IEntityTypeConfiguration<RankEntity>
    {
        public void Configure(EntityTypeBuilder<RankEntity> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AppData.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<BlogEntity>
    {
        public void Configure(EntityTypeBuilder<BlogEntity> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

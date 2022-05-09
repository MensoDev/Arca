using Arca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arca.Infrastructure.Configurations
{
    internal class TradingOperationConfiguration : IEntityTypeConfiguration<TradingOperation>
    {
        public void Configure(EntityTypeBuilder<TradingOperation> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(t => t.Title)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}

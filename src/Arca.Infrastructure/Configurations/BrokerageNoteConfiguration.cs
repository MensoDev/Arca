using Arca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arca.Infrastructure.Configurations
{
    internal class BrokerageNoteConfiguration : IEntityTypeConfiguration<BrokerageNote>
    {
        public void Configure(EntityTypeBuilder<BrokerageNote> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(p => p.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(p => p.Date)
                .IsRequired();

            builder
                .HasMany(brokerageNote => brokerageNote.Operations)
                .WithOne(tradingOperation => tradingOperation.BrokerageNote)
                .HasForeignKey(tradingOperation => tradingOperation.BrokerageNoteId);
        }
    }
}

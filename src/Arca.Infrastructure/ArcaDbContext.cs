using Arca.Domain.Entities;
using Arca.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Arca.Infrastructure;

public class ArcaDbContext : DbContext
{
    public ArcaDbContext(DbContextOptions<ArcaDbContext> options) : base(options) { }

    public DbSet<BrokerageNote> BrokerageNotes { get; set; }
    public DbSet<TradingOperation> TradingOperations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BrokerageNoteConfiguration());
        modelBuilder.ApplyConfiguration(new TradingOperationConfiguration());
    }
}

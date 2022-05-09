using Arca.Domain.Interfaces;

namespace Arca.Domain.Entities;

public partial class BrokerageNote : IEntity, IAggregateRoot
{
    private readonly List<TradingOperation> _operations;

    public BrokerageNote(string title, string description, DateOnly date)
    {
        Title = title;
        Description = description;
        Date = date;
        _operations = new List<TradingOperation>();
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateOnly Date { get; private set; }

    public IReadOnlyCollection<TradingOperation> Operations => _operations;

    public void RegisterOperations(TradingOperation operation)
    {
        if (operation is null) throw new ArgumentNullException(nameof(operation));
        _operations.Add(operation);
    }
}
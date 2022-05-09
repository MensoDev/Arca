using Arca.Domain.Enums;
using Arca.Domain.Interfaces;

namespace Arca.Domain.Entities;

public partial class TradingOperation : IEntity
{
    public TradingOperation(
        string title, 
        DateTime dateOfTransaction, 
        TradingOperationType type, 
        decimal pricePerUnit, 
        int quantity, 
        MarketType marketType, 
        BrokerageNote brokerageNote)
    {
        Title = title;
        DateOfTransaction = dateOfTransaction;
        Type = type;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
        MarketType = marketType;
        BrokerageNote = brokerageNote;
        BrokerageNoteId = brokerageNote.Id;
    }

    public string Title { get; private set; }
    public DateTime DateOfTransaction { get; private set; }
    public TradingOperationType Type { get; private set; }
    public decimal PricePerUnit { get; private set; }
    public int Quantity { get; private set; }
    public MarketType MarketType { get; private set; }

    public BrokerageNoteId BrokerageNoteId { get; private set; }
    public BrokerageNote BrokerageNote { get; private set; }
}
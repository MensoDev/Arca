using Arca.Domain.Entities;

namespace Arca.Domain.Repositories
{
    public interface IBrokerageNoteRepository : IRepositoryBase<BrokerageNote>
    {
        ValueTask<BrokerageNote> GetBrokerageNoteById(BrokerageNoteId brokerageNoteId);
        ValueTask<TradingOperation> GetTradingOperationById(TradingOperationId tradingOperationId);
    }
}

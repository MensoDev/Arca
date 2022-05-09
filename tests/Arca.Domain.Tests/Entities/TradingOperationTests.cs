using Arca.Domain.Entities;
using Arca.Domain.Enums;
using FluentAssertions;

namespace Arca.Domain.Tests.Entities;

public class TradingOperationTests
{
    [Fact]
    public void ShouldReturnSucessWhenTradingOperationIsValidTest()
    {
        //Arrange
        var brokerageNote = new BrokerageNote("abc", " abc", DateOnly.MaxValue);

        var tradingOperation = new TradingOperation(
            "Title Sample",
            DateTime.Now,
            TradingOperationType.C,
            2344.234M,
            5,
            MarketType.Fractional,
            brokerageNote
        );

        tradingOperation.Should().NotBeNull();
        tradingOperation.Id.Should().NotBeNull();
        tradingOperation.BrokerageNoteId.Should().NotBeNull();
    }
}
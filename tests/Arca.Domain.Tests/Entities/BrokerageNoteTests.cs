using Arca.Domain.Entities;
using FluentAssertions;

namespace Arca.Domain.Tests.Entities;

public class BrokerageNoteTests
{
    [Fact]
    public void ShouldReturnSuccessWhenBrokerageNoteIsValidTest()
    {
        var brokerageNote = new BrokerageNote("abc", "abc", DateOnly.MaxValue);

        brokerageNote.Should().NotBeNull();
        brokerageNote.Id.Should().NotBeNull();
    }
}
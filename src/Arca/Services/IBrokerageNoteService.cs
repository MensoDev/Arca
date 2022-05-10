using Arca.Models;

namespace Arca.Services;

public interface IBrokerageNoteService
{
    BrokerageNoteModel CreateBrokerageNoteByText(string text);
}
namespace Arca.Models;

public class BrokerageNoteModel
{
    public BrokerageNoteModel(string title)
    {
        Title = title;
        OperationModels = new List<TradingOperationModel>();
    }

    public string Title { get; private set; }

    public List<TradingOperationModel> OperationModels { get; set; }
}
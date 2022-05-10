using System.Text.RegularExpressions;
using Arca.Extensions;
using Arca.Models;

namespace Arca.Services;

public class BrokerageNoteService : IBrokerageNoteService
{
    private readonly Regex _regexNegotiation = new Regex(@"BOVESPA\s(?<CompraOuVenda>[CV])\s(?<TipoDeMercado>[A-Z]+)\s(?<Titulo>[\w\s]+?)(\s|(?<Observacao>[D\#]{1})\s)(?<Quantidade>\d+)\s(?<ValorUnitario>[\d\.]+,\d{2})\s(?<ValorTotal>[\d\.]+,\d{2})\s");
    private readonly Regex _regexDataValue = new Regex(@"\s*(?<Data>.+?)\s(?<Value>[\-\.\d]+,\d{2})");
    
    public BrokerageNoteModel CreateBrokerageNoteByText(string text)
    {
        var lines = text.ReplaceLineEndings().Split(Environment.NewLine);
        var model = new BrokerageNoteModel(Guid.NewGuid().ToString());
        foreach (var line in lines)
        {
            if (line.StartsWith("BOVESPA "))
            {
                var match = _regexNegotiation.Match(line);
                var item = match.SimpleDeserializer<TradingOperationModel>();
                model.OperationModels.Add(item);

            }
            else if(_regexDataValue.Match(line) is { } match)
            {
                
            }
        }

        return model;
    }
}
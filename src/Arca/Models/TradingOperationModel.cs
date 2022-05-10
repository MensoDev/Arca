using Arca.Attributes;

namespace Arca.Models;

public class TradingOperationModel
{
    [PropertyName("Titulo")]
    public string Title { get; set; }

    [PropertyName("Observacao")]
    public string Description { get; set; }

    [PropertyName("CompraOuVenda")]
    public string Type { get; set; }
    
    [PropertyName("ValorUnitario")]
    public string PricePerUnit { get; set; }
    
    [PropertyName("Quantidade")]
    public string Quantity { get; set; }
    
    [PropertyName("TipoDeMercado")]
    public string MarketType { get; set; }
}
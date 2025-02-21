using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Pricing;

public class PriceTable : EntityBase
{
    public string Name { get; set; }
    public DateTime ValidFrom { get; set; }
    public List<Price> Prices { get; set; }

    public PriceTable()
    {
        Prices = new List<Price>();
    }
}
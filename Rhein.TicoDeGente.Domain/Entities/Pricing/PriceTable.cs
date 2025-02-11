namespace Rhein.TicoDeGente.Domain.Entities.Pricing;

public class PriceTable
{
    public Ulid Id { get; set; }
    public string Name { get; set; }
    public DateTime ValidFrom { get; set; }
    public List<Price> Prices { get; set; }
}
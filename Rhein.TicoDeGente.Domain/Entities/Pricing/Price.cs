using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Pricing;

public class Price
{
    public Ulid Id { get; set; }
    public Product Product { get; set; }
    public decimal Value { get; set; }
    public decimal Discount { get; set; }
}

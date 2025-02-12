using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Pricing;

public class Price : EntityBase
{
    public Product Product { get; set; }
    public decimal Value { get; set; }
    public decimal Discount { get; set; }
}

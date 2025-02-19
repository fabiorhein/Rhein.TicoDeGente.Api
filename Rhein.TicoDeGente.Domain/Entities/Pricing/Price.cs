using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Pricing;

public class Price : EntityBase
{
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public PriceTable PriceTable { get; set; }
    public Guid PriceTableId { get; set; }
    public decimal Value { get; set; }
    public decimal Discount { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
}

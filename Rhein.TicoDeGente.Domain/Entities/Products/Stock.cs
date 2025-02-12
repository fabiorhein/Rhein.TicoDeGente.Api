using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Products;

public class Stock : EntityBase
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int ReservedQuantity { get; set; }
}

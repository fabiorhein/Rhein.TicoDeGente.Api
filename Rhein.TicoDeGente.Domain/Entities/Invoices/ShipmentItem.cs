using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class ShipmentItem
{
    public Ulid Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}

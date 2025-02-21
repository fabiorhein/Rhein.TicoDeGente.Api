using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class ShipmentItem : EntityBase
{
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }

    public Shipment Shipment { get; set; }
    public Guid ShipmentId { get; set; }

}

using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class ShipmentItem : EntityBase
{
    public Product Product { get; set; }
    public Ulid ProductId { get; set; }
    public int Quantity { get; set; }

    public Shipment Shipment { get; set; }
    public Ulid ShipmentId { get; set; }

}

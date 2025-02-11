using Rhein.TicoDeGente.Domain.Entities.Orders;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class Shipment
{
    public Ulid Id { get; set; }
    public Order Order { get; set; }
    public List<ShipmentItem> Items { get; set; }
    public DateTime ShipmentDate { get; set; }
}

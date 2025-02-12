using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Orders;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class Shipment : EntityBase
{
    public Order Order { get; set; }
    public List<ShipmentItem> Items { get; set; }
    public DateTime ShipmentDate { get; set; }
}

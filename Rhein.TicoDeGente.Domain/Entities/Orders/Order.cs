using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Customers;

namespace Rhein.TicoDeGente.Domain.Entities.Orders;

public class Order : EntityBase
{
    public Customer Customer { get; set; }
    public List<OrderItem> Items { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }
}

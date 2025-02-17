using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Customers;

namespace Rhein.TicoDeGente.Domain.Entities.Orders;

public class Order : EntityBase
{
    public List<OrderItem> Items { get; set; }
    public decimal TotalAmount => Items.Sum(i => (i.UnitPrice * i.Quantity) - (i.Discount?.Amount ?? 0));
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public Customer Customer { get; set; }
    public Guid CustomerId { get; set; }

    public Order()
    {
        Items = new List<OrderItem>();
    }
}

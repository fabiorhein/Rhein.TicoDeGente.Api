using Rhein.TicoDeGente.Domain.Entities.Customers;

namespace Rhein.TicoDeGente.Domain.Entities.Orders;

public class Order
{
    public Ulid Id { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItem> Items { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }
}

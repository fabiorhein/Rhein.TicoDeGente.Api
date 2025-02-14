using Rhein.TicoDeGente.Domain.Entities.Customers;

namespace Rhein.TicoDeGente.Domain.Entities.Orders;

public class Discount
{
    public decimal Percentage { get; set; }
    public decimal Amount => (Percentage / 100) * (OrderItem?.UnitPrice * OrderItem?.Quantity ?? 0);
    public OrderItem OrderItem { get; set; }
}
using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Orders;

namespace Rhein.TicoDeGente.Domain.Entities.Payments;

public class Payment : EntityBase
{
    public Order Order { get; set; }
    public decimal AmountPaid { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
}

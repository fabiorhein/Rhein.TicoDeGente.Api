using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Payments;

public class CashFlow : EntityBase
{
    public decimal Income { get; set; }
    public decimal Expense { get; set; }
    public DateTime Date { get; set; }
}

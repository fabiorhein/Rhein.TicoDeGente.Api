namespace Rhein.TicoDeGente.Domain.Entities.Payments;

public class CashFlow
{
    public Ulid Id { get; set; }
    public decimal Income { get; set; }
    public decimal Expense { get; set; }
    public DateTime Date { get; set; }
}

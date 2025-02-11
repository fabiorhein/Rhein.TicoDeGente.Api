using Rhein.TicoDeGente.Domain.Entities.Orders;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class Invoice
{
    public Ulid Id { get; set; }
    public Order Order { get; set; }
    public string Number { get; set; }
    public DateTime IssueDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<InvoiceItem> Items { get; set; }
}

using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class InvoiceItem : EntityBase
{
    public Product Product { get; set; }
    public Ulid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public Invoice Invoice { get; set; }
    public Ulid InvoiceId { get; set; }
}

using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Invoices;
using System.Net;

namespace Rhein.TicoDeGente.Domain.Entities.Customers;

public class Customer : EntityBase
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }
    public List<Invoice> Invoices { get; set; }
}

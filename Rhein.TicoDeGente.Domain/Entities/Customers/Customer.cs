using System.Net;

namespace Rhein.TicoDeGente.Domain.Entities.Customers;

public class Customer
{
    public Ulid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }
    public DateTime RegisteredAt { get; set; }
}

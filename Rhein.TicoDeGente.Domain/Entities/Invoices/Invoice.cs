﻿using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Customers;
using Rhein.TicoDeGente.Domain.Entities.Orders;

namespace Rhein.TicoDeGente.Domain.Entities.Invoices;

public class Invoice : EntityBase
{
    public Order Order { get; set; }
    public string Number { get; set; }
    public DateTime IssueDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<InvoiceItem> Items { get; set; }
    public Ulid CustomerId { get; set; }
    public Customer Customer { get; set; }
}

﻿using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Customers;
using Rhein.TicoDeGente.Domain.Entities.Invoices;
using Rhein.TicoDeGente.Domain.Entities.Orders;

namespace Rhein.TicoDeGente.Domain.Entities.Payments;

public class Payment : EntityBase
{
    public Order Order { get; set; }
    public Ulid OrderId { get; set; }
    public Invoice? Invoice { get; set; }
    public Guid? InvoiceId { get; set; }
    public Customer Customer { get; set; }
    public Ulid CustomerId { get; set; }
    public decimal AmountPaid { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public Ulid PaymentMethodId { get; set; }
}

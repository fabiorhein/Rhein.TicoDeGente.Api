﻿using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Domain.Entities.Orders;

public class OrderItem : EntityBase
{
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public Discount Discount { get; set; }

    public Guid OrderId { get; set; }
    public Order Order { get; set; }
}

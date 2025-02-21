using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Products;

public class Product : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public Guid CategoryId { get; set; }
    public Size Size { get; set; }
    public Guid SizeId { get; set; }
    public Color Color { get; set; }
    public Guid ColorId { get; set; }
    public decimal BasePrice { get; set; }
    public Stock Stock { get; set; }
}
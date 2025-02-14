using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Products;

public class Product : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public Ulid CategoryId { get; set; }
    public Size Size { get; set; }
    public Ulid SizeId { get; set; }
    public Color Color { get; set; }
    public Ulid ColorId { get; set; }
    public decimal BasePrice { get; set; }
    public Stock Stock { get; set; }
}
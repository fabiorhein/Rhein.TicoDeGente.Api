namespace Rhein.TicoDeGente.Domain.Entities.Products;

public class Product
{
    public Ulid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public Size Size { get; set; }
    public Color Color { get; set; }
    public decimal BasePrice { get; set; }
    public DateTime CreatedAt { get; set; }
}
namespace Rhein.TicoDeGente.Domain.Entities.Products;

public class Stock
{
    public Ulid Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int ReservedQuantity { get; set; }
}

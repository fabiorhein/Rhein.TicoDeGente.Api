namespace Rhein.TicoDeGente.Domain.Entities.Base;

public class EntityBase
{
    public Ulid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}

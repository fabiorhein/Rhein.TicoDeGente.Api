namespace Rhein.TicoDeGente.Domain.Entities.Base;

public class EntityBase
{
    private Guid _id;
    public Guid Id {
        get {
            if (_id == Guid.Empty)
            {
                _id = Guid.NewGuid();
            }
            return _id;
        }
        set => _id = value;
    }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsActive { get; set; } = true;
    public string CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}

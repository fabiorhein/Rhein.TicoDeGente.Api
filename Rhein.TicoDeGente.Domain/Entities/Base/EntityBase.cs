namespace Rhein.TicoDeGente.Domain.Entities.Base;

public class EntityBase
{
    private Ulid _id;
    public Ulid Id {
        get {
            if (_id == Ulid.Empty)
            {
                _id = Ulid.NewUlid();
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

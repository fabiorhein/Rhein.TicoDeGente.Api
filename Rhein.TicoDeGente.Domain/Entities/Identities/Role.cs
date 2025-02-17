using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Identities;

public class Role : EntityBase
{
    public string Name { get; set; }
    public List<RolePermission> RolePermissions { get; set; }
}

using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Identities;

public class Permission : EntityBase
{
    public string Name { get; set; }
    public List<RolePermission> RolePermissions { get; set; }
}

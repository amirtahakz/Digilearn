using Common.Domain;
using UserModule.Data.Entities._Enums;

namespace UserModule.Data.Entities.Roles;

public class RolePermission : BaseAggregateRoot
{
    public Guid RoleId { get; set; }
    public Permissions Permissions { get; set; }


    public Role Role { get; set; }
}
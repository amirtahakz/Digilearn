using System.ComponentModel.DataAnnotations;
using Common.Domain;

namespace UserModule.Data.Entities.Roles;

public class Role : BaseAggregateRoot
{

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
}
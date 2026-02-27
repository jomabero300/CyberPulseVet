using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPulseVet.Shared.Entities.Inve;

[Table("BaseUnitTypes", Schema = "Inv")]
public sealed class BaseUnitType
{
    public int Id { get; set; }

    [Column(TypeName = "varchar(40)")]
    [Display(Name = "Name", ResourceType = typeof(Literals))]
    [MaxLength(40, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string Name { get; set; } = string.Empty;
}
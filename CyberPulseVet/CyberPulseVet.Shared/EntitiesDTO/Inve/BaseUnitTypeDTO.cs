using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public sealed class BaseUnitTypeDTO
{
    public int Id { get; set; }

    [Column(TypeName = "varchar(40)")]
    [Display(Name = "Name", ResourceType = typeof(Literals))]
    [MaxLength(40, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string Name { get; set; } = string.Empty;
}
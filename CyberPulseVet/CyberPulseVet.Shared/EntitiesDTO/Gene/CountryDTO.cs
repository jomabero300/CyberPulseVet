using CyberPulseVet.Shared.Entities.Gene;
using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace CyberPulseVet.Shared.EntitiesDTO.Gene;

public sealed class CountryDTO
{
    public int Id { get; set; }

    [Display(Name = "Name", ResourceType = typeof(Literals))]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string Name { get; set; } = null!;

    public ICollection<State>? States { get; set; }

    public int StatesNumber => States == null ? 0 : States.Count;
}
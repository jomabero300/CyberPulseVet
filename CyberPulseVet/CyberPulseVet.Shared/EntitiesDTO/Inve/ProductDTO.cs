using CyberPulseVet.Shared.EntitiesDTO.Gene;
using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public sealed class ProductDTO : ProductBaseDTO
{

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public CategoryDTO? Category { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public StatuDTO? Statu { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public UnitMeasurementDTO2? UnitMeasurement { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public IvaDTO? Iva { get; set; }
}

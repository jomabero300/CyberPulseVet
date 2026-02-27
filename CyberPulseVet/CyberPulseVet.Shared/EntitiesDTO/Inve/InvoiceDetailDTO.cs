using CyberPulseVet.Shared.EntitiesDTO.Gene;
using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public sealed class InvoiceDetailDTO: InvoiceDetailBaseDTO
{
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public ProductBaseDTO? Product { get; set; } = new ProductBaseDTO();

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public IvaBaseDTO? Iva { get; set; }
    public int InvoiceDetailId { get; set; }
    public int BaseValue { get; set; }

}

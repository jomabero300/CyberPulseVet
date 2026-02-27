using CyberPulseVet.Shared.EntitiesDTO.Gene;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public sealed class StockDTO : StockBaseDTO
{
    public ProductBaseDTO? Product { get; set; }
}
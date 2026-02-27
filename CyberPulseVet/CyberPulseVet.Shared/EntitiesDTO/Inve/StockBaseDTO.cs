using CyberPulseVet.Shared.EntitiesDTO.Gene;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public class StockBaseDTO
{
    public int Id { get; set; }
    public int InvoiceDetailId { get; set; }
    public int ProductId { get; set; }
    public int IvaId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime? DateExpiration { get; set; }

    public InvoiceDetailBaseDTO? InvoiceDetail { get; set; }
    public IvaBaseDTO? Iva { get; set; }
}
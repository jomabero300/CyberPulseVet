using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public class InvoiceDetailBaseDTO
{
    public int Id { get; set; }
    public int InvoiceId { get; set; }


    [Display(Name = "Product", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int ProductId { get; set; }

    [Display(Name = "Iva", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int IvaId { get; set; }

    [Display(Name = "Quantity", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(0, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int Quantity { get; set; }

    [Display(Name = "Quantity", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(0, double.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal Quantity2 { get; set; }

    [Display(Name = "PurchasePrice", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, double.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal PurchasePrice { get; set; }

    [Display(Name = "Price", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(0, double.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal Price { get; set; }

    [Display(Name = "DateExpiration", ResourceType = typeof(Literals))]
    public DateTime? DateExpiration { get; set; }

    [Display(Name = "Code", ResourceType = typeof(Literals))]
    public string Code { get; set; } = string.Empty;

    public int QuantityStock { get; set; }
    public int StockId { get; set; }
    public decimal QuantityOutPut { get; set; }

    public decimal SubTotalSale => Quantity == 0 ? 0 : Math.Round(Quantity * Price, 0, MidpointRounding.AwayFromZero);
    public decimal SubTotalSale2 => Quantity2 == 0 ? 0 : Quantity2 * Price;
    public decimal SubTotalBuy => Quantity == 0 ? 0 : Quantity * PurchasePrice;
}

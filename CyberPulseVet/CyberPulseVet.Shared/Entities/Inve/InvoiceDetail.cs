using CyberPulseVet.Shared.Entities.Gene;
using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPulseVet.Shared.Entities.Inve;

[Table("InvoiceDetails", Schema = "Inv")]
public sealed class InvoiceDetail
{
    public int Id { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int InvoiceId { get; set; }

    [Display(Name = "Product", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int ProductId { get; set; }

    [Display(Name = "Iva", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int IvaId { get; set; }

    [Display(Name = "Quantity", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int Quantity { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    [Display(Name = "PurchasePrice", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, double.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal PurchasePrice { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    [Display(Name = "Price", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, double.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal Price { get; set; }

    [Display(Name = "DateExpiration", ResourceType = typeof(Literals))]
    public DateTime? DateExpiration { get; set; }

    public Iva? Iva { get; set; }
    public Invoice? Invoice { get; set; }
    public Product? Product { get; set; }
}
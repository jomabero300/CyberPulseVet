using CyberPulseVet.Shared.Entities.Gene;
using CyberPulseVet.Shared.Enums;
using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPulseVet.Shared.Entities.Inve;
[Table("Invoices", Schema = "Inv")]
public sealed class Invoice
{
    public int Id { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int CompanyId { get; set; }

    [Display(Name = "Store", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int StoreId { get; set; }

    [Display(Name = "Dian", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int DianId { get; set; }

    [Column(TypeName = "varchar(20)")]
    [Display(Name = "InvoiceDian", ResourceType = typeof(Literals))]
    [MaxLength(20, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string InvoiceNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    [Display(Name = "Date", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public DateTime? Date { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "InvoiceDate", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public DateTime? InvoiceDate { get; set; }

    [Display(Name = "InvoiceType", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public InvoiceType InvoiceType { get; set; }

    [Display(Name = "Payment", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int PaymentId { get; set; }

    [Column(TypeName = "nvarchar(450)")]
    [Display(Name = "Customer", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string CustomerId { get; set; } = null!;

    [Column(TypeName = "nvarchar(450)")]
    [Display(Name = "Employee", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "decimal(10,2)")]
    [Display(Name = "Total", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal Total { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    [Display(Name = "Amount", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal Amount { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Display(Name = "Statu", ResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int StatuId { get; set; }

    public Payment? Payment { get; set; }
    public Statu? Statu { get; set; }
    public User? Customer { get; set; }
    public User? Employee { get; set; }
    public Store? Store { get; set; }
    public Dian? Dian { get; set; }
    public Company? Company { get; set; }

    public ICollection<InvoiceDetail>? invoiceDetails { get; set; }
    public decimal Change => Total == 0 ? 0 : Amount - Total;
}
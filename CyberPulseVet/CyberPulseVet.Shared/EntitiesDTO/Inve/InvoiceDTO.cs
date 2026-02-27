using CyberPulseVet.Shared.EntitiesDTO.Gene;
using CyberPulseVet.Shared.Enums;
using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public sealed class InvoiceDTO
{
    public int Id { get; set; }

    [Display(Name = "Store", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int StoreId { get; set; }

    [Display(Name = "Dian", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int DianId { get; set; }

    [Display(Name = "InvoiceDian", ResourceType = typeof(Literals))]
    [MaxLength(20, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string InvoiceNumber { get; set; } = null!;

    [Display(Name = "Date", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public DateTime Date { get; set; }

    [Display(Name = "InvoiceDate", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public DateTime? InvoiceDate { get; set; }

    [Display(Name = "InvoiceType", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public InvoiceType InvoiceType { get; set; }

    [Display(Name = "Payment", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int PaymentId { get; set; }

    [Display(Name = "Customer", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string CustomerId { get; set; } = null!;

    [Display(Name = "Employee", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string EmployeeId { get; set; } = null!;

    [Display(Name = "Total", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal Total { get; set; }

    [Display(Name = "Statu", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int StatuId { get; set; }


    [Display(Name = "Amount", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal Amount { get; set; }


    [Display(Name = "Change", ResourceType = typeof(Literals))]
    public decimal Change => SubTotalSale == 0 ? 0 : Amount - SubTotalSale;


    public decimal SubTotalSale => invoiceDetails?.Sum(x => x.SubTotalSale) ?? 0;
    public decimal SubTotalBuy => invoiceDetails?.Sum(x => x.SubTotalBuy) ?? 0;
    public List<InvoiceDetailDTO> invoiceDetails { get; set; } = new();


    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public StatuDTO? Statu { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public PaymentDTO? Payment { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public User2DTO? Customer { get; set; }

    public int CompanyId { get; set; }

}
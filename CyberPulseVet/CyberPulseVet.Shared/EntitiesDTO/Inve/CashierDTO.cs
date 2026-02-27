using CyberPulseVet.Shared.EntitiesDTO.Gene;
using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public class CashierDTO
{
    public int Id { get; set; }

    [Display(Name = "Date", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public DateTime? Date { get; set; } = DateTime.UtcNow;

    [Display(Name = "Cash", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int Cash { get; set; }

    [Display(Name = "Employee", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string EmployeeId { get; set; } = null!;

    [Display(Name = "InitialFund", ResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public decimal InitialFund { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Display(Name = "Statu", ResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int StatuId { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public StatuDTO? Statu { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public User2DTO? Employee { get; set; }
}
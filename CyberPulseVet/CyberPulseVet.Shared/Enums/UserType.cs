using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace CyberPulseVet.Shared.Enums;

public enum UserType
{
    [Display(Name = "Admi", ResourceType = typeof(Literals))]
    Admi,
    [Display(Name = "Cashier", ResourceType = typeof(Literals))]
    Cash,
    [Display(Name = "Supplier", ResourceType = typeof(Literals))]
    Supp,
    [Display(Name = "Customer", ResourceType = typeof(Literals))]
    Cust,
    [Display(Name = "User", ResourceType = typeof(Literals))]
    User
}
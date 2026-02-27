using CyberPulseVet.Shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace CyberPulseVet.Shared.Enums;

public enum InvoiceType
{
    [Display(Name = "Inputs", ResourceType = typeof(Literals))]
    Inputs,
    [Display(Name = "Output", ResourceType = typeof(Literals))]
    Output,
    [Display(Name = "Unsubscribe", ResourceType = typeof(Literals))]
    Unsubscribe
}
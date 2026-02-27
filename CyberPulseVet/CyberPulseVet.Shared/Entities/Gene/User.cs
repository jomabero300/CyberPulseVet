using CyberPulseVet.Shared.Entities.Inve;
using CyberPulseVet.Shared.Enums;
using CyberPulseVet.Shared.Resources;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPulseVet.Shared.Entities.Gene;

public sealed class User : IdentityUser
{
    [Column(TypeName = "varchar(12)")]
    [Display(Name = "DocumentId", ResourceType = typeof(Literals))]
    [MaxLength(12, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string DocumentId { get; set; } = null!;

    [Column(TypeName = "varchar(60)")]
    [Display(Name = "FirstName", ResourceType = typeof(Literals))]
    [MaxLength(60, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string FirstName { get; set; } = null!;

    [Column(TypeName = "varchar(60)")]
    [Display(Name = "LastName", ResourceType = typeof(Literals))]
    [MaxLength(60, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "varchar(100)")]
    [Display(Name = "Image", ResourceType = typeof(Literals))]
    public string? Photo { get; set; }


    [Display(Name = "UserType", ResourceType = typeof(Literals))]
    public UserType UserType { get; set; }

    [Display(Name = "Country", ResourceType = typeof(Literals))]
    [Range(1, int.MaxValue, ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public int CountryId { get; set; }

    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public Country Country { get; set; } = null!;


    [Display(Name = "User", ResourceType = typeof(Literals))]
    public string FullName => $"{FirstName} {LastName}";
    public string PhotoFull => string.IsNullOrEmpty(Photo) ? "/images/NoImage.png" : Photo;

    public ICollection<Cashier>? Cashiers { get; set; }
}
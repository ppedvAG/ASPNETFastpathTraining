using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNETFastpathTraining.Models;

public partial class Kunde
{
    [MaxLength(50)]
    public int KundeId { get; set; }
    [Required]
    [Display(Name ="Name Kunde")]
    [StringLength(10,ErrorMessage ="Max 10 Zeichen",MinimumLength =3)]
    public string? Name { get; set; }
    [Required]
    [Display(Name = "Postleitzahl")]
    [StringLength(5, ErrorMessage = "Max 10 Zeichen", MinimumLength = 5)]
    //[Range(string,"01000","99999",ErrorMessage ="Postleitzahl ungültig")]
       public string? Plz { get; set; }

    public string? Land { get; set; }

    public string? Ort { get; set; }

    public DateTime Datum { get; set; }

    public virtual ICollection<Auftrag> Auftrags { get; set; } = new List<Auftrag>();
}

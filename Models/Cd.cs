using System.ComponentModel.DataAnnotations;

namespace dt191g_moment32.Models;

public class Cd
{
    public int CdId { get; set; }
    
    [Required]
    [Display(Name = "Titel")]
    public string? Title { get; set; }
    
    [Required]
    public string? Genre { get; set; }
  
    [Required]
    [Display(Name = "Speltid (minuter)")]
    public int Playtime { get; set; }

    [Required]
    [Display(Name = "Artist")]
    public int ArtistId { get; set; }
    public Artist? Artist { get; set; }
    
    public Loan? Loan { get; set; }
}
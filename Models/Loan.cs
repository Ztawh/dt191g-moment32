using System.ComponentModel.DataAnnotations;

namespace dt191g_moment32.Models;

public class Loan
{
    public int LoanId { get; set; }
 
    [Required]
    [Display(Name = "Kundnamn")]
    public string? Name { get; set; }
  
    [Required]
    [Display(Name = "Datum")]
    public string? Date { get; set; }

    [Required]
    [Display(Name = "CD")]
    public int CdId { get; set; }
    public Cd? Cd { get; set; }
}
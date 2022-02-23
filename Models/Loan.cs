using System.ComponentModel.DataAnnotations;

namespace dt191g_moment32.Models;

public class Loan
{
    public int LoanId { get; set; }
 
    [Required(ErrorMessage = "Ange ett namn")]
    [Display(Name = "Namn")]
    public string? Name { get; set; }
  
    [Required(ErrorMessage = "Ange ett datum för utlåning")]
    [Display(Name = "Datum")]
    public string? Date { get; set; }

    [Required(ErrorMessage = "Välj CD")]
    [Display(Name = "CD")]
    public int CdId { get; set; }
    public Cd? Cd { get; set; }
}
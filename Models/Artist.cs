using System.ComponentModel.DataAnnotations;

namespace dt191g_moment32.Models;

public class Artist
{
    public int ArtistId { get; set; }
    
    [Required(ErrorMessage = "Ange en artist/band")]
    [Display(Name = "Artist/band")]
    public string? Name { get; set; }

    public List<Cd>? Cds { get; set; }
}
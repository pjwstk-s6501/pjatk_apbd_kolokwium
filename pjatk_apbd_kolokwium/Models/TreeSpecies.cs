using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pjatk_apbd_kolokwium.Models;

[Table("Tree_Species")]
public class TreeSpecies
{
    [Key]
    public int SpeciesId { get; set; }
    
    [Required]
    [StringLength(100)]
    public string LatinName { get; set; }
    
    [Required]
    public int GrowthTimeInYears { get; set; }
}
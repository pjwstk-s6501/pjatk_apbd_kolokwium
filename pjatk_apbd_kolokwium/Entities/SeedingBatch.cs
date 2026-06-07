using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pjatk_apbd_kolokwium.Models;

[Table("Seedling_Batch")]
public class SeedingBatch
{
    [Key]
    public int BatchId { get; set; }
    
    public int NurseryId { get; set; }
    
    public int SpeciesId { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    
    [Required]
    public DateTime SownDate { get; set; }
    
    public DateTime ReadyDate { get; set; }
}
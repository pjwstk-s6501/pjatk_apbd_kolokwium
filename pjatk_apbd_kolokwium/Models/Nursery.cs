using System.ComponentModel.DataAnnotations;

namespace pjatk_apbd_kolokwium.Models;

public class Nursery
{
    [Key]
    public int NurseryId { get; set; }
    
    [StringLength(100)]
    [Required]
    public string Name { get; set; }
    
    [Required]
    public DateTime EstablishedDate;
    
}
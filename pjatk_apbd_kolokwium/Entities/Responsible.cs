using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace pjatk_apbd_kolokwium.Models;

[PrimaryKey("SeedingBatchId","EmployeeId")]
public class Responsible
{
    public int SeedingBatchId { get; set; }
    public SeedingBatch SeedingBatch { get; set; }
    
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Role { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace pjatk_apbd_kolokwium.Models;

public class Employee
{
    [Key]
    public int EmployeeId { set; get; }
    
    [Required]
    [StringLength(100)]
    public string FirstName { set; get; }
    
    [Required]
    [StringLength(100)]
    public string LastName { set; get; }
    
    [Required]
    public DateTime HireDate { set; get; }
}
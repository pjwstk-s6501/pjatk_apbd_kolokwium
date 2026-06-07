namespace pjatk_apbd_kolokwium.Models;

public class Responsible
{
    public int SeedingBatchId { get; set; }
    public SeedingBatch SeedingBatch { get; set; }
    public int EmployeeId { get; set; }
    public string Role { get; set; }
}
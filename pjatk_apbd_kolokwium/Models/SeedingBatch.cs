namespace pjatk_apbd_kolokwium.Models;

public class SeedingBatch
{
    public int BatchId { get; set; }
    public int NurseryId { get; set; }
    public int SpeciesId { get; set; }
    public int QuantityId { get; set; }
    public DateTime SownDate { get; set; }
    public DateTime ReadyDate { get; set; }
}
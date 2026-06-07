using pjatk_apbd_kolokwium.Models;

namespace pjatk_apbd_kolokwium.DTO;

public class ResponsibleDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public String Role { get; set; }
}

public class TreeSpieciesDTO
{
    public String LatinName { set; get; }
}

public class NurseryBatchDTO {
    
    public int BatchId { get; set; }
    public int Qunatity { get; set; }
    public DateTime DownDate {get; set; }
    public DateTime ReadyDate { get; set; }
    public IEnumerable<TreeSpieciesDTO> Species { get; set; }
    public IEnumerable<ResponsibleDTO> Responsible { get; set; }
}

public class NurseryDTO
{
    public NurseryDTO(Nursery nursery)
    {
        NurseryId = nursery.NurseryId;
        Name = nursery.Name;
        EstablishedDate = nursery.EstablishedDate;
    }
    
    public int NurseryId { get; set; }
    public String Name { get; set; }
    public DateTime EstablishedDate { get; set; }
}
using Microsoft.AspNetCore.Mvc;
using pjatk_apbd_kolokwium.DTO;

namespace pjatk_apbd_kolokwium.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NurseriesController : ControllerBase
{
    
    
    
    [HttpGet("{id:int}/batches")]
    public ActionResult<List<NurseryDTO>> GetWithBatches(int id)
    {
        return Ok(new List<NurseryDTO>());
    }
    
    
    
}
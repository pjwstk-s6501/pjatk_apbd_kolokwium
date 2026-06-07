using Microsoft.AspNetCore.Mvc;
using pjatk_apbd_kolokwium.Data;
using pjatk_apbd_kolokwium.DTO;
using pjatk_apbd_kolokwium.Models;

namespace pjatk_apbd_kolokwium.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NurseriesController : ControllerBase
{
    
    private readonly NurseriesDbContext _dbContext;

    public NurseriesController(NurseriesDbContext db) => _dbContext = db;
    
    [HttpGet("{id:int}/batches")]
    public ActionResult<NurseryDTO> GetWithBatches(int id)
    {
        Nursery? nursery = _dbContext.Nurseries.Find(id);
        
        if (nursery == null)
        {
            return NotFound();
        }
        else
        {
            NurseryDTO nurseryDto = new NurseryDTO(nursery);
            return Ok(nurseryDto);
        }
    }
    
    
    
}
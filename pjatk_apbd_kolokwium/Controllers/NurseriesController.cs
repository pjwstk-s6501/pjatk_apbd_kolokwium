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
            var batches = _dbContext.SeedingBatches.Where(batch => batch.NurseryId == nursery.NurseryId).ToList();
            var batchesDtos = new List<NurseryBatchDTO>();
            foreach (var batch in batches)
            {
                var nurseryBatchDto = new NurseryBatchDTO();
                nurseryBatchDto.BatchId = batch.BatchId;
                nurseryBatchDto.Quantity = batch.Quantity;
                nurseryBatchDto.SownDate = batch.SownDate;
                nurseryBatchDto.ReadyDate = batch.ReadyDate;
                var responsibles = _dbContext.Responsibles
                    .Where(responsible => responsible.SeedingBatchId == batch.BatchId).ToList();
                var responsiblesDtos = new List<ResponsibleDTO>();
                foreach (var responsible in responsibles)
                {
                    var responsibleDto = new ResponsibleDTO();
                    responsibleDto.FirstName = responsible.Employee.FirstName;
                    responsibleDto.LastName = responsible.Employee.LastName;
                    responsibleDto.Role = responsible.Role;
                }

                nurseryBatchDto.Responsible = responsiblesDtos;
                batchesDtos.Add(nurseryBatchDto);
            }
            nurseryDto.Batches = batchesDtos;
            return Ok(nurseryDto);
        }
    }
    
    
    
}
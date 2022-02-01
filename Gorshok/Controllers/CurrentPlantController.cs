using GorshokApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GorshokApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentPlantController : ControllerBase
    {
        private GorshokContext _dbContext;
        public CurrentPlantController(GorshokContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetCurrentPlant/{id}")]
        public IActionResult Get(int id)
        {
            CurrentPlant plantFromDb = _dbContext.CurrentPlants
                .Include(e => e.Status)
                .Include(e => e.Plant)
                .FirstOrDefault(e => e.Id == id);
            
            if(plantFromDb == null)
            {
                return NotFound();
            }

            return Ok(plantFromDb);
        }

        [HttpPost("CreateCurrentPlant")]
        public IActionResult Create([FromBody] CurrentPlant plant)
        {
            _dbContext.Add(plant);
            _dbContext.SaveChanges();

            return CreatedAtAction("GetPlant", new { id = plant.Id }, plant);
        }

        [HttpPut("UpdateCurrentPlant")]
        public IActionResult Update([FromBody] CurrentPlant plant)
        {
            return Ok();
        }

        [HttpDelete("DeleteCurrentPlant/{id}")]
        public IActionResult Delete(int id)
        {
            var currentPlant = _dbContext.CurrentPlants.FirstOrDefault(e => e.Id == id);
            _dbContext.Entry(currentPlant).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return Ok(); 
        }
    }
}

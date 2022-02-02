using GorshokApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GorshokApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private GorshokContext _dbContext;

        public UserController(GorshokContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetUser/{id}")]
        public IActionResult Get(int id)
        {
            /*UserPlant userPlantFromDb = _dbContext.UserPlants
                .Include(e => e.User)
                .Include(e => e.CurrentPlant)
                .Include(e => e.User.Role)
                .Include(e => e.CurrentPlant.Plant)
                .Include(e => e.CurrentPlant.Status)
                .FirstOrDefault(e => e.UserId == id);*/
            return Ok();
        }
        
    }
}

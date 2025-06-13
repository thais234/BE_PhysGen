using BE_PhysGen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_PhysGen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateExam(string difficulty, string format, string topic )
        {
            
            return Ok("Creating exam with ai successfully");
        }
    }
}

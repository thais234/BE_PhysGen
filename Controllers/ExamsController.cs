using BE_PhysGen.Data;
using BE_PhysGen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_PhysGen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        [HttpGet("{id}")]
        public IActionResult GetExam(int id)
        {
            return Ok($"Exam with ID {id}, connect db soon");
        }
        [HttpGet("DemoExam/{classtype}")]
        public IActionResult GetDemoExam(int classtype)
        {
            return Ok($"Exam with ID {classtype}, connect db soon");
        }
        [HttpPost]
        public IActionResult CreateExam(string classtype, string difficulty, string topic )
        {
            
            return Ok("Creating exam with ai successfully");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateExam(int id, string classtype, string difficulty, string topic)
        {
            return Ok($"Updated exam with ID {id} successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExam(int id)
        {
            return Ok($"Deleted user with ID {id} successfully");
        }
    }
}

using BE_PhysGen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_PhysGen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetQuestion(int id)
        {
            return Ok($"Question with ID {id}, connect db soon");
        }
        [HttpGet("{type}")]
        public IActionResult GetQuestionsByType(string type)
        {
            return Ok($"Questions of type {type}, connect db soon");
        }
        [HttpPost]
        public IActionResult CreateQuestion(QuestionDTO questionDTO)
        {
            return Ok($"Questions added, connect db soon");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateQuestion(int id, QuestionDTO questionDTO)
        {
            return Ok($"Updated question with ID {id} successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteQuestion(int id)
        {
            return Ok($"Deleted question with ID {id} successfully");

        }
}

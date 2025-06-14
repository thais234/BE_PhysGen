using BE_PhysGen.Data;
using BE_PhysGen.Models;
using BE_PhysGen.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_PhysGen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public readonly IUsersService _usersService;

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok($"User with ID {id}, connect db soon");
        }
        [HttpPost]
        public IActionResult CreateUser(UsersDTO usersDTO)
        {
            //var user = new Users()
            //{
            //    Username = employeeDTO.Username,
            //    Email = employeeDTO.Email,
            //    FullName = employeeDTO.FullName,
            //    Password = employeeDTO.Password,
            //    Role = "Employee"
            //};
            //dbContext.Users.Add(user);
            //dbContext.SaveChanges();

            return Ok("Added user successfully");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UsersDTO usersDTO)
        {
            //var user = dbContext.Users.Find(id);
            //if (user == null)
            //{
            //    return NotFound();
            //}
            //user.Username = employeeDTO.Username;
            //user.Email = employeeDTO.Email;
            //user.FullName = employeeDTO.FullName;
            //user.Password = employeeDTO.Password;
            //dbContext.SaveChanges();
            return Ok($"Updated user with ID {id} successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            //var user = dbContext.Users.Find(id);
            //if (user == null)
            //{
            //    return NotFound();
            //}
            //dbContext.Users.Remove(user);
            //dbContext.SaveChanges();
            return Ok($"Deleted user with ID {id} successfully");
        }
    }
}

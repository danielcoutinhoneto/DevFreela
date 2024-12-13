using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users?search=nome
        [HttpGet]
        public IActionResult Get(string search)
        {
            return Ok();
        }

        // GET api/users/123
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1}, model);
        }

        // PUT api/users/123
        [HttpPut("id")]
        public IActionResult Put(int id, UpdateUserInputModel model)
        {
            return NoContent();
        }

        // DELETE api/users/123
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
       
    }
}

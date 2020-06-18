using Microsoft.AspNetCore.Mvc;

namespace ProjectSchool_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : Controller
    {
        public ProfessorController()
        {
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok();
        }
        
        [HttpGet("ProfessorId")]
        public IActionResult get(int ProfessorId)
        {
            return Ok();   
        }

        [HttpPost]
        public IActionResult post()
        {
            return Ok();
        }

        [HttpPut("ProfessorId")]
        public IActionResult put(int ProfessorId)
        {
            return Ok();
        }

        [HttpDelete("ProfessorId")]
        public IActionResult delete(int ProfessorId)
        {
            return Ok();
        }
    }
}
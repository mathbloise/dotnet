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
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }
        
        [HttpGet("ProfessorId")]
        public IActionResult get(int ProfessorId)
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }   
        }

        [HttpPost]
        public IActionResult post()
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpPut("ProfessorId")]
        public IActionResult put(int ProfessorId)
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpDelete("ProfessorId")]
        public IActionResult delete(int ProfessorId)
        {
            try
            {
                return Ok();
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }
    }
}
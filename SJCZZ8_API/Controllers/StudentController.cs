using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJCZZ8_API.Models;

namespace SJCZZ8_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult AllStudents()
        {
            StudentContext context = new StudentContext();
            return Ok(context.Students.ToList());
        }
    }
}

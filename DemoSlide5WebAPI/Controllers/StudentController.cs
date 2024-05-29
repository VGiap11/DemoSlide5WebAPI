using DemoSlide5WebAPI.API.IRepository;
using DemoSlide5WebAPI.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoSlide5WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepositoryStudent _studentRepository;

        public StudentController(IRepositoryStudent studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents() => _studentRepository.Students;

        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Vui long nhap student can tim");
            }
            return Ok(_studentRepository[id]);
        }
    }
}

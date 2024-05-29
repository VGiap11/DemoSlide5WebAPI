using DemoSlide5WebAPI.API.IRepository;
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


    }
}

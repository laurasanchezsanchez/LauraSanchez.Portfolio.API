using LauraSanchez.Portfolio.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace LauraSanchez.Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : ControllerBase
    {
        [HttpGet]
        public ActionResult<About> Get()
        {
            var about = new About
            {
                Name = "Laura Sánchez",
                Role = "Backend Developer",
                Description = "Backend developer with experience in C# and .NET, REST APIs, and SQL databases. Passionate about clean code and scalable solutions.",
                Location = "Linares, Andalusia, Spain",
                Email = "tu@email.com",
                GitHub = "https://github.com/tuusuario",
                LinkedIn = "https://linkedin.com/in/tuusuario"
            };

            return Ok(about);
        }
    }
}
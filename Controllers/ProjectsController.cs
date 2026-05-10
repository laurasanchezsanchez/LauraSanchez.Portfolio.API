using LauraSanchez.Portfolio.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace LauraSanchez.Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Project>> Get()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Portfolio API",
                    Description = "Personal portfolio backend built with ASP.NET Core 10 and REST APIs.",
                    Technologies = new List<string> { "C#", "ASP.NET Core", "REST APIs", ".NET 10" },
                    GitHubUrl = "https://github.com/tuusuario/LauraSanchez.Portfolio.API"
                }
            };

            return Ok(projects);
        }
    }
}
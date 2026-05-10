using LauraSanchez.Portfolio.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace LauraSanchez.Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Experience>> Get()
        {
            var experience = new List<Experience>
            {
                new Experience
                {
                    Company = "Solera Inc.",
                    Role = "Backend Developer",
                    StartDate = "October 2022",
                    EndDate = "Present",
                    Description = "Backend development in an international team, building and maintaining REST APIs and data pipelines for the automotive and insurance industry.",
                    Technologies = new List<string> { "C#", ".NET Framework 4.8", "ASP.NET Web API", "SQL Server", "MySQL", "MongoDB", "Entity Framework", "Jenkins", "IIS" }
                },
                new Experience
                {
                    Company = "Innovasur",
                    Role = "Cybersecurity Analyst Intern",
                    StartDate = "2021",
                    EndDate = "2021",
                    Description = "5-month internship focused on cybersecurity analysis.",
                    Technologies = new List<string> { "Cybersecurity" }
                }
            };

            return Ok(experience);
        }
    }
}
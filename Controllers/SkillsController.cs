using LauraSanchez.Portfolio.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace LauraSanchez.Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Skill>> Get()
        {
            var skills = new List<Skill>
            {
                new Skill { Name = "C#", Category = "Languages" },
                new Skill { Name = "ASP.NET Core", Category = "Frameworks" },
                new Skill { Name = "REST APIs", Category = "Frameworks" },
                new Skill { Name = "Entity Framework", Category = "Frameworks" },
                new Skill { Name = "SQL Server", Category = "Databases" },
                new Skill { Name = "MySQL", Category = "Databases" },
                new Skill { Name = "MongoDB", Category = "Databases" },
                new Skill { Name = "Jenkins", Category = "DevOps" },
                new Skill { Name = "Git", Category = "DevOps" },
                new Skill { Name = "Docker", Category = "DevOps" }
            };

            return Ok(skills);
        }
    }
}
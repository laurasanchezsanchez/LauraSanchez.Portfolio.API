using LauraSanchez.Portfolio.API.Models;
using LauraSanchez.Portfolio.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace LauraSanchez.Portfolio.API.Controllers
{
    [EnableRateLimiting("fixed")]
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class SkillsController : ControllerBase
    {
        private readonly IPortfolioService _service;

        public SkillsController(IPortfolioService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Skill>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Skill>>> Get()
        {
            var skills = await _service.GetSkillsAsync();
            return Ok(skills);
        }
    }
}
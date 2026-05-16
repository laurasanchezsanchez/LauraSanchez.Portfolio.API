using LauraSanchez.Portfolio.API.Models;
using LauraSanchez.Portfolio.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LauraSanchez.Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ExperienceController : ControllerBase
    {
        private readonly IPortfolioService _service;

        public ExperienceController(IPortfolioService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Experience>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Experience>>> Get()
        {
            var experience = await _service.GetExperienceAsync();
            return Ok(experience);
        }
    }
}
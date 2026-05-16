using LauraSanchez.Portfolio.API.Models;
using LauraSanchez.Portfolio.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LauraSanchez.Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProjectsController : ControllerBase
    {
        private readonly IPortfolioService _service;

        public ProjectsController(IPortfolioService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Project>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Project>>> Get()
        {
            var projects = await _service.GetProjectsAsync();
            return Ok(projects);
        }
    }
}
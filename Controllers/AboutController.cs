using LauraSanchez.Portfolio.API.Exceptions;
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
    public class AboutController : ControllerBase
    {
        private readonly IPortfolioService _service;

        public AboutController(IPortfolioService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(About), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<About>> Get()
        {
            var about = await _service.GetAboutAsync();

            if (about is null)
                throw new NotFoundException("About");

            return Ok(about);
        }
    }
}
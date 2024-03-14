using FloraPOC.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FloraPOC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SpeciesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Get")]
        public async Task<IActionResult> GetSpecies(SearchRequestDto input)
        {
            var species = await _mediator.Send(new GetSpeciesQuery(input));
            return Ok(species);
        }
    }
}

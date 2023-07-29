using Gangster.ApiModel.ApiResponse;
using Gangster.Application.Gangster.Commands.CreateGangsterHandler;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gangster.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GangsterController : ControllerBase
{
    private readonly IMediator _mediator;

    public GangsterController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("Gangsters")]
    public async Task<ActionResult<APIResponse<CreateGangsterResponse>>> Gangsters([FromBody] CreateGangsterRequest request)
    {
        return await _mediator.Send(request);
    }
}
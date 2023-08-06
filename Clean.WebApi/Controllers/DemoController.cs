using Clean.Application.Demo.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly IMediator _mediator;

    public DemoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("Demo")]
    public async Task<ActionResult<List<GetDemoResponse>>> Demo()
    {
        var getDemo = new GetDemoQuery();
        return await _mediator.Send(getDemo);
    }

}

using Clean.Application.Common.AppConfiguration;
using Clean.Application.Demo.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Clean.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly AppSettings _appSettings;
    public DemoController(IMediator mediator, IOptions<AppSettings> appsettings)
    {
        _mediator = mediator;
        _appSettings = appsettings.Value;
    }

    [HttpGet("Demo")]
    public async Task<ActionResult<List<GetDemoResponse>>> Demo()
    {
        var getDemo = new GetDemoQuery();
        return await _mediator.Send(getDemo);
    }

}

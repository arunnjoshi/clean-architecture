using Clean.Application.Common.AppConfiguration;
using Clean.Application.Common.Response;
using Clean.Application.Demo.Queries.Id;
using Clean.Application.Demo.Queries.List;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Clean.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
//[AllowAnonymous]
[Authorize]
public class DemoController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly AppSettings _appSettings;
    public DemoController(IMediator mediator, IOptions<AppSettings> appSettings)
    {
        _mediator = mediator;
        _appSettings = appSettings.Value;
    }

    [HttpGet("Demo")]
    public async Task<ApiResponse<List<GetDemoResponse>>> Demo()
    {
        var getDemo = new GetDemoQuery();
        return await _mediator.Send(getDemo);
    }

    [HttpGet("Demo/{id}")]
    public async Task<ApiResponse<GetDemoResponse>> Demo(Guid id)
    {
        var getDemo = new GetDemoByIdQuery { Id = id };
        return await _mediator.Send(getDemo);
    }
}
using Gangster.ApiModel.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace Gangster.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GangsterController : ControllerBase
{
    [HttpGet("Gangsters")]
    public ActionResult<APIResponse<string>> Gangsters()
    {
        return APIResponse<string>.SendResponse(StatusCodes.Status200OK, "this is message", "this is data", true);
    }
}
using Clean.Application.Common.Authentication;
using Clean.Application.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clean.WebApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	[AllowAnonymous]
	public class TokenController : ControllerBase
	{
		private readonly JwtTokenService _jwtTokenService;
		public TokenController(JwtTokenService jwtTokenService)
		{
			_jwtTokenService = jwtTokenService;
		}

		[HttpPost("CreateToken")]
		public ActionResult<ApiResponse<string>> CreateToken(LoginModel login)
		{
			var token = _jwtTokenService.CreateToken();
			return ApiResponse<string>.sendResponse(token, "Login successfully.", true, StatusCodes.Status200OK);
		}
	}
}


public class LoginModel
{
	public string UserName { get; set; } = null!;
	public string Password { get; set; } = null!;
}
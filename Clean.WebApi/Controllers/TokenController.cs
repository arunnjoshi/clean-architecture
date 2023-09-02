using Clean.Application.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Clean.WebApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	[AllowAnonymous]
	public class TokenController : ControllerBase
	{
		//private readonly JwtTokenService _jwtTokenService;
		public TokenController()
		{
			//_jwtTokenService = jwtTokenService;
		}

		[HttpGet("CreateToken")]
		public ActionResult<ApiResponse<string>> CreateToken()
		{
			return ApiResponse<string>.sendResponse("", "Login sucessfully.", true, StatusCodes.Status200OK);
		}
	}
}

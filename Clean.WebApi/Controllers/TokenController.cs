using Clean.Application.Common.Authentication;
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

        [HttpGet("CreateToken")]
        public string CreateToken()
        {
            return _jwtTokenService.CreateToken();
        }
    }
}

using Clean.Application.Common.AppConfiguration;
using Clean.Application.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Clean.Application.Common.Authentication
{
	public class JwtTokenService
	{
		private readonly JwtSettings _jwtSettings;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public JwtTokenService(IOptions<JwtSettings> options, SignInManager<ApplicationUser> signInManager)
		{
			_jwtSettings = options.Value;
			_signInManager = signInManager;
		}

		public async Task<string> CreateToken()
		{
			var user = await _signInManager.PasswordSignInAsync("administrator@localhost", "Admin@1234", false, false);

			var secretKey = _jwtSettings.Key;

			var tokenHandler = new JwtSecurityTokenHandler();
			var tokenKey = Encoding.UTF8.GetBytes(secretKey);

			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
				{
					new(ClaimTypes.Name, "ArunJoshi")
				}),

				Expires = DateTime.UtcNow.AddMinutes(10),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
			};

			var token = tokenHandler.CreateToken(tokenDescriptor);
			return tokenHandler.WriteToken(token);
		}
	}
}

using Microsoft.AspNetCore.Identity;

namespace Clean.Application.User;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string MeddleName { get; set; }
    public string LastName { get; set; }
    public string RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTIme { get; set; }
}

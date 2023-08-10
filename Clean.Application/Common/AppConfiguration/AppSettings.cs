namespace Clean.Application.Common.AppConfiguration;

public class AppSettings
{
    public string Name { get; set; }
    public ConnectionStrings connectionStrings { get; set; }
}

public class ConnectionStrings
{
    public string Default { get; set; }
}

public class JwtSettings
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string Key { get; set; }
    public int ExpieryTime { get; set; }
}
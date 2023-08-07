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
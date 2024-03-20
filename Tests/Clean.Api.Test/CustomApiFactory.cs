using Clean.WebApi.MappingFile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;

namespace Clean.Api.Test;

public class CustomApiFactory : WebApplicationFactory<IApiMaker>
{
	protected override void ConfigureWebHost(IWebHostBuilder builder)
	{
		builder.ConfigureLogging(l =>
		{
			l.ClearProviders();
		});

		builder.ConfigureTestServices(Services =>
		{
			//configure your services here
		});
	}
}

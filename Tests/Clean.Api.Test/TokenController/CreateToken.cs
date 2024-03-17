using System.Net.Http.Json;
using Clean.Application.Common.Response;
using Clean.WebApi.MappingFile;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Clean.Api.Test.TokenController;

public class CreateToken
{
	private readonly WebApplicationFactory<IApiMaker> _app = new();
	private readonly HttpClient httpClient;
	public CreateToken()
	{
		httpClient = _app.CreateClient();
	}

	[Fact]
	public async Task CreateToken_WhenPassword_Is_Valid()
	{
		var res = await httpClient.GetAsync("Token/CreateToken");
		var data = await res.Content.ReadFromJsonAsync<ApiResponse<string>>();
		data!.StatusCode.Should().Be(StatusCodes.Status200OK);
		data!.Status.Should().Be(true);
		data!.Data.Should().NotBeEmpty();
	}
}
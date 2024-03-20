using System.Net.Http.Json;
using Clean.Application.Common.Response;
using FluentAssertions;
using Microsoft.AspNetCore.Http;

namespace Clean.Api.Test.TokenController;

public class CreateToken(CustomApiFactory customApiFactory) : IClassFixture<CustomApiFactory>
{
	readonly HttpClient httpClient = customApiFactory.CreateClient();

	[Fact]
	public async Task CreateToken_WhenPassword_Is_Valid()
	{
		var res = await httpClient.PostAsJsonAsync("/Token/CreateToken", new LoginModel { Password = "password", UserName = "userName" });
		var data = await res.Content.ReadFromJsonAsync<ApiResponse<string>>();
		data!.StatusCode.Should().Be(StatusCodes.Status200OK);
		data!.Status.Should().Be(true);
		data!.Data.Should().NotBeEmpty();
	}
}
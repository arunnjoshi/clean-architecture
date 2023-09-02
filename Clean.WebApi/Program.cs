using Clean.Infrastructure;
using Clean.WebApi.Exceptions;
using Clean.Application;
using Clean.Application.Common.AppConfiguration;
using Clean.Application.Common.Authentication;
using Clean.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
builder.Services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
builder.Services.AddJWTAuthentication(configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices(configuration);
builder.Services.AddInfrastructureServices(configuration);
builder.Services.AddAuthorization();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    await app.InitializeDatabaseAsync();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();
//app.MapControllers().RequireAuthorization();
app.UseMiddleware<CustomExceptionHandler>();

app.Run();

//dotnet ef migrations add "adding identity user" --project Clean.Infrastructure --startup-project Clean.WebApi --output-dir Data\Migrations
//dotnet ef database update  --project Clean.Infrastructure --startup-project Clean.WebApi
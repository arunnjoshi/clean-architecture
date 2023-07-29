
using FluentValidation;
using Newtonsoft.Json;
using System.Net;

namespace Gangster.WebApi.Infrastructure;

public class CustomExceptionHandler 
{
    private readonly RequestDelegate _next;

    public CustomExceptionHandler(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ValidationException ex)
        {
            await HandleValidationExceptionAsync(context, ex);
        }
    }

    private static async Task HandleValidationExceptionAsync(HttpContext context, ValidationException ex)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

        var errors = ex.Errors.Select(error => new
        {
            error.PropertyName,
            error.ErrorMessage
        });

        var result = JsonConvert.SerializeObject(new { Errors = errors });
        await context.Response.WriteAsync(result);
    }
}

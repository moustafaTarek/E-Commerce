using System.Text.Json;
using Template.API.Layer.Error;

namespace Template.API.Layer.Midddleware
{
	// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
	public class ExceptionHandlerMiddleware
	{
		private readonly RequestDelegate _next;

		public ExceptionHandlerMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext httpContext)
		{
			try
			{
				await _next(httpContext);
			}
			catch (Exception ex)
			{
				await HandleExceptionAsync(httpContext, ex);
			}
		}

		private async Task HandleExceptionAsync(HttpContext context, Exception ex)
		{
			context.Response.ContentType = "application/json";

			// Set the response status code to 500 (Internal Server Error)
			context.Response.StatusCode = StatusCodes.Status500InternalServerError;

			var response = new ApiErrorResponse(ex.Message, StatusCodes.Status500InternalServerError , ex.StackTrace);

			var options = new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase
			};

			var serializedResponse = JsonSerializer.Serialize(response, options);

			// Write a custom error message or JSON response
			await context.Response.WriteAsync(serializedResponse);
		}
	}

	// Extension method used to add the middleware to the HTTP request pipeline.
	public static class ExceptionHandlerMiddlewareExtensions
	{
		public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<ExceptionHandlerMiddleware>();
		}
	}
}

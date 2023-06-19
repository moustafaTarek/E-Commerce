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

		public async Task InvokeAsyc(HttpContext httpContext)
		{
			try
			{
				await _next(httpContext);
			}
			catch (Exception ex)
			{
				await httpContext.Response.WriteAsync(ex.Message);
			}
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

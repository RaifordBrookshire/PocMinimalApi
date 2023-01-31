namespace PocMinimalApi.Middleware
{
	public class GlobalExceptionHandler : IMiddleware
	{
		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{
			Console.WriteLine($"Before Next() in GlobalExceptionHandler.InvokeAsync()");
			await next(context);
			Console.WriteLine($"After Next() in GlobalExceptionHandler.InvokeAsync()");
		}
	}
}

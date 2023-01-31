namespace PocMinimalApi.Endpoints
{
	public class AuthenticationEndpoint
	{
		public static void Handler() => Console.WriteLine($"Inside AuthenticationEndpoint.Handler() ");

		internal static Task LoginHandler(HttpContext context)
		{
			throw new NotImplementedException();
		}

		internal static Task LogoutHandler(HttpContext context)
		{
			throw new NotImplementedException();
		}
	}
}

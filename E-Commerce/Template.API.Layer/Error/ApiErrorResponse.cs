namespace Template.API.Layer.Error
{
	public class ApiErrorResponse
	{
		public string Message { get; set; }
		public int StatusCode { get; set; }
		public string StackTrace { get; set; }

		public ApiErrorResponse(string message, int statusCode, string stackTrace)
		{
			Message = message;
			StatusCode = statusCode;
			StackTrace = stackTrace;
		}
	}
}

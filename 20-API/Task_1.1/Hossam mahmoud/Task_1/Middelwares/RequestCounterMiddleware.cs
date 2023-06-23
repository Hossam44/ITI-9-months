namespace Task_1.Middelwares
{
    public class RequestCounterMiddleware
    {
        private readonly RequestDelegate _next;
        public int _requestCount = 0;

        public RequestCounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            _requestCount++;
            await _next(context);
        }
    }
}

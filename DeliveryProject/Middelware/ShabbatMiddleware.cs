namespace DeliveryProject.Middelware
{
    public class ShabbatMiddleware
    {

        private readonly RequestDelegate _next;
        public ShabbatMiddleware( RequestDelegate next)
        {
             _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if(DayOfWeek.Saturday==DateTime.Now.DayOfWeek)
            {
                context.Response.StatusCode=StatusCodes.Status400BadRequest;
                context.Response.ContentType = "text/plain; charset=utf-8";
                await context.Response.WriteAsync("השבת היא ה-❤️ של העם היהודי");
                return;
            }
            await _next(context);
        }
    
    }
}

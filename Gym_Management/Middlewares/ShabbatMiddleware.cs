namespace Gym_Management.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;   
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var shabbat = false;
            DayOfWeek d = new DateTime().DayOfWeek;
            if (d == DayOfWeek.Saturday)
                shabbat = true;

            if (shabbat)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                Console.WriteLine("Shbbat today!");
                return;
            }
            else
            {
                await _next(context);
            }
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Serilog;
using System.Threading.Tasks;

namespace ProjectReactServer.Middleware
{
    public class LogMiddleware 
    {
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            var myAction = httpContext.GetRouteData().Values["action"]?.ToString();
            Log.Information("I am in Middleware");
            Log.Information(myAction);
            await _next(httpContext);
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Serilog;
using System.Threading.Tasks;

namespace ProjectReactServer
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exeption"+ex.Message);
                Log.Error("message: " + ex.Message + "source: "
                + ex.Source + "InnerException :" + ex.InnerException);

            }
           
        }
    }

}

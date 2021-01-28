using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Serilog;
using Ticket.Presentation.Models;

namespace Ticket.Presentation.Middlewares
{
    public class ExceptionHandling
    {
        private readonly RequestDelegate _next;
        private static ILogger _logger = Log.ForContext<ExceptionHandling>();


        public ExceptionHandling(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var now = DateTime.UtcNow;

            _logger.Error($"{now.ToString("HH:mm:ss")} : {ex}");
            
            return httpContext.Response.WriteAsync(JsonSerializer.Serialize(new ErrorResultModel()
            {
                StatusCode = httpContext.Response.StatusCode,
                Message = ex.Message
            }));
        }
    }
}

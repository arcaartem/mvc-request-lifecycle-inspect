using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace mvc_lifecycle.Filters
{
    public class MiddlewareBase
    {
        private readonly RequestDelegate _next;
        private readonly ConsoleLogger _logger;

        protected MiddlewareBase(RequestDelegate next)
        {
            _next = next;
            _logger = new ConsoleLogger();
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.IndentAndLog(CreateLogMessage(context.Request.Path));
            await _next(context);
            _logger.OutdentAndLog(CreateLogMessage(context.Request.Path, isAfter: true));
        }
        
        private string CreateLogMessage(string path, bool isAfter = false)
        {
            var typeName = GetType().Name;
            var prefix = isAfter ? "After" : "Before";
            var message = $"{prefix} {typeName}.InvokeAsync (Path: {path})";
            return message;
        }
    }
    
    public class Middleware1 : MiddlewareBase
    {
        public Middleware1(RequestDelegate next) : base(next)
        {
        }
    }
    
    public class Middleware2 : MiddlewareBase
    {
        public Middleware2(RequestDelegate next) : base(next)
        {
        }
    }
}
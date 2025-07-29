using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Filters
{
    public class LogActivityFilter : IAsyncActionFilter
    {
        private readonly ILogger<LogActivityFilter> _logger;

        public LogActivityFilter(ILogger<LogActivityFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation($"Action { context.ActionDescriptor.DisplayName} is being executed at {DateTime.UtcNow}");
            await next();
            _logger.LogInformation($"Action {context.ActionDescriptor.DisplayName} has completed execution at {DateTime.UtcNow} with result: {context.Result?.GetType().Name ?? "No Result"}");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Middlewares
{
    public class LimitRatingMiddleware
    {
        private readonly RequestDelegate _next;
        private static int _counter = 0;
        private static DateTime _lastDateTime = DateTime.Now;
        public LimitRatingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            _counter++;
            if(DateTime.Now.Subtract(_lastDateTime).Seconds > 10)
            {
                _counter = 1;
                _lastDateTime = DateTime.Now;
                await _next(context);
            }
            else
            {
                if (_counter > 5)
                {
                    _lastDateTime = DateTime.Now;
                    await context.Response.WriteAsync(context.Request.Path + " - Too many requests. Please try again in 10 seconds");
                }
                else
                {
                    _lastDateTime = DateTime.Now;
                    await _next(context);
                }
            }
        }
    }
}

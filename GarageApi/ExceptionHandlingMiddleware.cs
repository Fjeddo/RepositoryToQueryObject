using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GarageApi
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                if (e is KeyNotFoundException)
                {
                    context.Response.Clear();
                    context.Response.StatusCode = (int) HttpStatusCode.NotFound;

                    await context.Response.WriteAsync(e.Message);
                }

            }
        }
    }
}
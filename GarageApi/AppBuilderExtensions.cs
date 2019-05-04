using Microsoft.AspNetCore.Builder;

namespace GarageApi
{
    public static class AppBuilderExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ExceptionHandlingMiddleware>();

            return builder;
        }
    }
}
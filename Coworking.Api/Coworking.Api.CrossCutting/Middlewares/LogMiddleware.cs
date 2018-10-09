using Microsoft.AspNetCore.Builder;

namespace Coworking.Api.CrossCutting.Middlewares
{
    public static class LogMiddleware
    {
        public static IApplicationBuilder UseLogMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<Log>();
            return builder;
        }
    }
}

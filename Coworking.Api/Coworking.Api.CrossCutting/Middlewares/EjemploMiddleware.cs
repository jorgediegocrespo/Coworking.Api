using Microsoft.AspNetCore.Builder;

namespace Coworking.Api.CrossCutting.Middlewares
{
    public static class EjemploMiddleware
    {
        public static IApplicationBuilder UseEjemploMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<Ejemplo>();
            return builder;
        }
    }
}

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Coworking.Api.CrossCutting.Middlewares
{
    public class Ejemplo
    {
        private readonly RequestDelegate _next;

        public Ejemplo(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Any action

            await _next(context);

            //Other action
        }
    }
}

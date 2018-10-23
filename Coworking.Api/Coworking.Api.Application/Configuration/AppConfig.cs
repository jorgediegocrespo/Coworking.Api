using Dicres.RepositoryService.Application.Configuration;
using Microsoft.Extensions.Configuration;

namespace Coworking.Api.Application.Configuration
{
    public class AppConfig : IAppConfig
    {
        private readonly IConfiguration _configuracion;

        public AppConfig(IConfiguration configuration)
        {
            _configuracion = configuration;
        }

        public int MaxTrys => int.Parse(_configuracion.GetSection("Polly:MaxTrys").Value);
        public int SecondToWait => int.Parse(_configuracion.GetSection("Polly:TimeDelay").Value);
    }
}

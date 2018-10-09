using Coworking.Api.Application.Configuration;
using Moq;

namespace Coworking.Api.Application.Tests.Config
{
    public class AppConfigMock
    {
        public Mock<IAppConfig> AppConfig { get; set; }

        public AppConfigMock()
        {
            AppConfig = new Mock<IAppConfig>();
            Setup();
        }

        private void Setup()
        {
            
        }
    }
}

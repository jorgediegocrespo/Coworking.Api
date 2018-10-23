using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Services;
using Coworking.Api.Application.Tests.Config;
using Coworking.Api.Application.Tests.MockRepository;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Dicres.RepositoryService.Application.Configuration;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Tests
{
    [TestClass]
    public class AdminServiceTest
    {
        private static IAdminService _adminService;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            Mock<IAdminRepository> adminRepository = new AdminRepositoryMock().AdminRepository;
            Mock<IAppConfig> appConfig = new AppConfigMock().AppConfig;

            _adminService = new AdminService(adminRepository.Object, appConfig.Object);
        }

        [TestMethod]
        public async Task AdminService_Get_Ok()
        {
            //preparation

            //execution
            var result = await _adminService.Get(1);

            //assertions
            result.Should().NotBeNull();
            result.Id.Should().BePositive();
            result.Name.Should().NotBeNullOrWhiteSpace();
        }

        [TestMethod]
        public async Task AdminService_GetAll_Ok()
        {
            //preparation

            //execution
            var result = await _adminService.GetAll();

            //assertions
            result.Should().NotBeNull();
            result.Should().HaveCountGreaterThan(0);
        }
    }
}

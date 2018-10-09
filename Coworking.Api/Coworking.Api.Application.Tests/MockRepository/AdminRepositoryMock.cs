using Coworking.Api.Application.Tests.Stubs;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Moq;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Tests.MockRepository
{
    public class AdminRepositoryMock
    {
        public Mock<IAdminRepository> AdminRepository { get; set; }

        public AdminRepositoryMock()
        {
            AdminRepository = new Mock<IAdminRepository>();
            Setup();
        }

        private void Setup()
        {
            AdminRepository.Setup((x) => x.Exists(It.Is<int>(p => p > 0))).ReturnsAsync(true);
            AdminRepository.Setup((x) => x.Exists(It.Is<int>(p => p <= 0))).ReturnsAsync(false);
            AdminRepository.Setup((x) => x.GetAll()).ReturnsAsync(AdminStub.AdminList);
            AdminRepository.Setup((x) => x.Get(It.IsAny<int>())).ReturnsAsync(AdminStub.Admin_1);
            AdminRepository.Setup((x) => x.DeleteAsync(It.Is<int>(p => p > 0))).Returns(Task.Delay(5));
            AdminRepository.Setup((x) => x.Update(It.IsAny<AdminEntity>())).ReturnsAsync(AdminStub.Admin_2);
            AdminRepository.Setup((x) => x.Add(It.IsAny<AdminEntity>())).ReturnsAsync(AdminStub.Admin_1);
        }
    }
}

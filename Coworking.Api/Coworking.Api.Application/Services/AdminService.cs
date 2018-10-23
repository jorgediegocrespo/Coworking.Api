using Dicres.RepositoryService.Application.Configuration;
using Dicres.RepositoryService.Application.Services;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;

namespace Coworking.Api.Application.Services
{
    public class AdminService : BaseService<Admin, AdminEntity>, IAdminService
    {
        public AdminService(IAdminRepository adminRepository, IAppConfig appConfig) 
            : base(adminRepository, appConfig, new AdminMapper())
        { }
    }
}

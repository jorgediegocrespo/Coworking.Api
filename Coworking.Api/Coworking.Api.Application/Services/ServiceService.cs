using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Dicres.RepositoryService.Application.Configuration;
using Dicres.RepositoryService.Application.Services;

namespace Coworking.Api.Application.Services
{
    public class ServiceService : BaseService<Service, ServiceEntity>, IServiceService
    {
        public ServiceService(IServiceRepository ServiceRepository, IAppConfig appConfig)
            : base(ServiceRepository, appConfig, new ServiceMapper())
        { }
    }
}

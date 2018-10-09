using Coworking.Api.Application.Configuration;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;

namespace Coworking.Api.Application.Services
{
    public class OfficeService : BaseService<Office, OfficeEntity>, IOfficeService
    {
        public OfficeService(IOfficeRepository OfficeRepository, IAppConfig appConfig)
            : base(OfficeRepository, appConfig, new OfficeMapper())
        { }
    }
}

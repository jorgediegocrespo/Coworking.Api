using Dicres.RepositoryService.Api.Controllers;
using Dicres.RepositoryService.Api.Mappers;
using Dicres.RepositoryService.Api.ViewModels;
using Dicres.RepositoryService.Application.Configuration;
using Dicres.RepositoryService.Application.Contracts.Services;
using Dicres.RepositoryService.Business.Models;
using Microsoft.AspNetCore.Authorization;

namespace Coworking.Api.Controllers
{
    [Authorize]
    public class CoworkingBaseController<T, R> : BaseController<T, R>
        where T : BaseModel
        where R : BaseBusinessModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        /// <param name="config"></param>
        /// <param name="mapper"></param>
        public CoworkingBaseController(IBaseCrudService<R> service, IAppConfig config, IMapper<T, R> mapper) : base(service, config, mapper)
        {}
    }
}

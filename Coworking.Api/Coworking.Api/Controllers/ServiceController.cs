using Coworking.Api.Application.Configuration;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.Mappers;
using Coworking.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.Controllers
{
    /// <summary>
    /// Service controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/service")]
    public class ServiceController : BaseController<ServiceModel, Service>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serviceService"></param>
        /// /// <param name="config"></param>
        public ServiceController(IServiceService serviceService, IAppConfig config) : base(serviceService, config, new ServiceMapper())
        {
        }

        /// <summary>
        /// Returns every service
        /// </summary>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(IEnumerable<ServiceModel>))]
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return await base.Get();
        }

        /// <summary>
        /// Returns the service with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(ServiceModel))]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return await base.Get(id);
        }

        /// <summary>
        /// Create a new service
        /// </summary>
        /// <param name="service"></param>
        /// <returns>Service</returns>
        [Produces("application/json", Type = typeof(ServiceModel))]
        [HttpPost]
        public override async Task<IActionResult> Post([FromBody]ServiceModel service)
        {
            return await base.Post(service);
        }

        /// <summary>
        /// Update an service
        /// </summary>
        /// <param name="service"></param>
        [Produces("application/json", Type = typeof(ServiceModel))]
        [HttpPut]
        public override async Task<IActionResult> Put([FromBody]ServiceModel service)
        {
            return await base.Put(service);
        }

        /// <summary>
        /// Delete an service
        /// </summary>
        /// <param name="id"></param>
        [Produces("application/json", Type = typeof(bool))]
        [HttpDelete("{id}")]
        public override async Task<IActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}

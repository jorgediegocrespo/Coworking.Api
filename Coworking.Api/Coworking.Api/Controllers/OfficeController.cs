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
    /// Office controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/office")]
    public class OfficeController : BaseController<OfficeModel, Office>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="officeService"></param>
        /// /// <param name="config"></param>
        public OfficeController(IOfficeService officeService, IAppConfig config) : base(officeService, config, new OfficeMapper())
        {
        }

        /// <summary>
        /// Returns every office
        /// </summary>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(IEnumerable<OfficeModel>))]
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return await base.Get();
        }

        /// <summary>
        /// Returns the office with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(OfficeModel))]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return await base.Get(id);
        }

        /// <summary>
        /// Create a new office
        /// </summary>
        /// <param name="office"></param>
        /// <returns>Office</returns>
        [Produces("application/json", Type = typeof(OfficeModel))]
        [HttpPost]
        public override async Task<IActionResult> Post([FromBody]OfficeModel office)
        {
            return await base.Post(office);
        }

        /// <summary>
        /// Update an office
        /// </summary>
        /// <param name="office"></param>
        [Produces("application/json", Type = typeof(OfficeModel))]
        [HttpPut]
        public override async Task<IActionResult> Put([FromBody]OfficeModel office)
        {
            return await base.Put(office);
        }

        /// <summary>
        /// Delete an office
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

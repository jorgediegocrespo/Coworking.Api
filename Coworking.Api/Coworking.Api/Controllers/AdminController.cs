using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.Mappers;
using Coworking.Api.ViewModels;
using Dicres.RepositoryService.Application.Configuration;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.Controllers
{
    /// <summary>
    /// Admin controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/admin")]
    public class AdminController : CoworkingBaseController<AdminModel, Admin>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="adminService"></param>
        /// /// <param name="config"></param>
        public AdminController(IAdminService adminService, IAppConfig config) : base(adminService, config, new AdminMapper())
        {
        }

        /// <summary>
        /// Returns every admin
        /// </summary>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(IEnumerable<AdminModel>))]
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return await base.Get();
        }

        /// <summary>
        /// Returns the admin with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(AdminModel))]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return await base.Get(id);
        }

        /// <summary>
        /// Create a new Admin
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Admin</returns>
        [Produces("application/json", Type=typeof(AdminModel))]
        [HttpPost]
        public override async Task<IActionResult> Post([FromBody]AdminModel admin)
        {
            return await base.Post(admin);
        }

        /// <summary>
        /// Update an admin
        /// </summary>
        /// <param name="admin"></param>
        [Produces("application/json", Type = typeof(AdminModel))]
        [HttpPut]
        public override async Task<IActionResult> Put([FromBody]AdminModel admin)
        {
            return await base.Put(admin);
        }

        /// <summary>
        /// Delete an admin
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

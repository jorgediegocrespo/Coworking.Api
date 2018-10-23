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
    /// User controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : CoworkingBaseController<UserModel, User>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userService"></param>
        /// /// <param name="config"></param>
        public UserController(IUserService userService, IAppConfig config) : base(userService, config, new UserMapper())
        {
        }

        /// <summary>
        /// Returns every user
        /// </summary>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(IEnumerable<UserModel>))]
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return await base.Get();
        }

        /// <summary>
        /// Returns the user with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(UserModel))]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return await base.Get(id);
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User</returns>
        [Produces("application/json", Type = typeof(UserModel))]
        [HttpPost]
        public override async Task<IActionResult> Post([FromBody]UserModel user)
        {
            return await base.Post(user);
        }

        /// <summary>
        /// Update an user
        /// </summary>
        /// <param name="user"></param>
        [Produces("application/json", Type = typeof(UserModel))]
        [HttpPut]
        public override async Task<IActionResult> Put([FromBody]UserModel user)
        {
            return await base.Put(user);
        }

        /// <summary>
        /// Delete an user
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

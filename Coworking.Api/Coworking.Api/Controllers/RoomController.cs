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
    /// Room controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/room")]
    public class RoomController : CoworkingBaseController<RoomModel, Room>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="roomService"></param>
        /// /// <param name="config"></param>
        public RoomController(IRoomService roomService, IAppConfig config) : base(roomService, config, new RoomMapper())
        {
        }

        /// <summary>
        /// Returns every room
        /// </summary>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(IEnumerable<RoomModel>))]
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return await base.Get();
        }

        /// <summary>
        /// Returns the room with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(RoomModel))]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return await base.Get(id);
        }

        /// <summary>
        /// Create a new room
        /// </summary>
        /// <param name="room"></param>
        /// <returns>Room</returns>
        [Produces("application/json", Type = typeof(RoomModel))]
        [HttpPost]
        public override async Task<IActionResult> Post([FromBody]RoomModel room)
        {
            return await base.Post(room);
        }

        /// <summary>
        /// Update an room
        /// </summary>
        /// <param name="room"></param>
        [Produces("application/json", Type = typeof(RoomModel))]
        [HttpPut]
        public override async Task<IActionResult> Put([FromBody]RoomModel room)
        {
            return await base.Put(room);
        }

        /// <summary>
        /// Delete an room
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

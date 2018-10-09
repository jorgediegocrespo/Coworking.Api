using Coworking.Api.Application.Configuration;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.Mappers;
using Coworking.Api.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Controllers
{
    /// <summary>
    /// Base controller
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="R"></typeparam>
    [Authorize]
    public class BaseController<T, R> : Controller
        where T : BaseModel
        where R : Base
    {
        private readonly IBaseCrudService<R> _service;
        private readonly IAppConfig _config;
        private readonly IMapper<T, R> _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        /// /// <param name="config"></param>
        /// /// <param name="mapper"></param>
        public BaseController(IBaseCrudService<R> service, IAppConfig config, IMapper<T, R> mapper)
        {
            _service = service;
            _config = config;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns every item
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        public virtual async Task<IActionResult> Get()
        {
            var entities = await _service.GetAll();
            return Ok(entities.Select(o => _mapper.Map(o)).ToList());
        }

        /// <summary>
        /// Returns the item with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        public virtual async Task<IActionResult> Get(int id)
        {
            var entity = await _service.Get(id);
            return Ok(_mapper.Map(entity));
        }

        /// <summary>
        /// Create a new item
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Item</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        public virtual async Task<IActionResult> Post(T item)
        {
            var created = await _service.Add(_mapper.Map(item));
            return Ok(_mapper.Map(created));
        }

        /// <summary>
        /// Update an item
        /// </summary>
        /// <param name="item"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        public virtual async Task<IActionResult> Put(T item)
        {
            var updated = await _service.Update(_mapper.Map(item));
            return Ok(_mapper.Map(updated));
        }

        /// <summary>
        /// Delete an item by id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.Delete(id);
            return Ok(deleted);
        }
    }
}

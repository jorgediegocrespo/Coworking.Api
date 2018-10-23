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
    /// Booking controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/booking")]
    public class BookingController : CoworkingBaseController<BookingModel, Booking>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bookingService"></param>
        /// /// <param name="config"></param>
        public BookingController(IBookingService bookingService, IAppConfig config) : base(bookingService, config, new BookingMapper())
        {
        }

        /// <summary>
        /// Returns every booking
        /// </summary>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(IEnumerable<BookingModel>))]
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return await base.Get();
        }

        /// <summary>
        /// Returns the booking with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json", Type = typeof(BookingModel))]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return await base.Get(id);
        }

        /// <summary>
        /// Create a new booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns>Booking</returns>
        [Produces("application/json", Type = typeof(BookingModel))]
        [HttpPost]
        public override async Task<IActionResult> Post([FromBody]BookingModel booking)
        {
            return await base.Post(booking);
        }

        /// <summary>
        /// Update an booking
        /// </summary>
        /// <param name="booking"></param>
        [Produces("application/json", Type = typeof(BookingModel))]
        [HttpPut]
        public override async Task<IActionResult> Put([FromBody]BookingModel booking)
        {
            return await base.Put(booking);
        }

        /// <summary>
        /// Delete an booking
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

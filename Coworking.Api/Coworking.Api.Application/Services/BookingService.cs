using Coworking.Api.Application.Configuration;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;

namespace Coworking.Api.Application.Services
{
    public class BookingService : BaseService<Booking, BookingEntity>, IBookingService
    {
        public BookingService(IBookingRepository bookingRepository, IAppConfig appConfig)
            : base(bookingRepository, appConfig, new BookingMapper())
        { }
    }
}

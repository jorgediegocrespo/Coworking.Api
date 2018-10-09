using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;

namespace Coworking.Api.Mappers
{
    public class BookingMapper : IMapper<BookingModel, Booking>
    {
        public Booking Map(BookingModel dto)
        {
            return new Booking()
            {
                Id = dto.Id,
                UserId = dto.UserId,
                BookingDate = dto.BookingDate,
                CreateDate = dto.CreateDate,
                OfficeId = dto.OfficeId,
                RentWorkSpace = dto.RentWorkSpace,
                RoomId = dto.RoomId
            };
        }

        public BookingModel Map(Booking dto)
        {
            return new BookingModel()
            {
                Id = dto.Id,
                UserId = dto.UserId,
                BookingDate = dto.BookingDate,
                CreateDate = dto.CreateDate,
                OfficeId = dto.OfficeId,
                RentWorkSpace = dto.RentWorkSpace,
                RoomId = dto.RoomId
            };
        }
    }
}

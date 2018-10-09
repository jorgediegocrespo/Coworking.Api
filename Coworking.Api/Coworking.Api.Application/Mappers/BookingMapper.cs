using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;

namespace Coworking.Api.Application.Mappers
{
    public class BookingMapper : IMapper<Booking, BookingEntity>
    {
        public BookingEntity Map(Booking dto)
        {
            return new BookingEntity()
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

        public Booking Map(BookingEntity dto)
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

    }
}

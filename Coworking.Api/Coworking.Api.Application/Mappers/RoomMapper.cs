using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;

namespace Coworking.Api.Application.Mappers
{
    public class RoomMapper : IMapper<Room, RoomEntity>
    {
        public RoomEntity Map(Room dto)
        {
            return new RoomEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Capacity = dto.Capacity
            };
        }

        public Room Map(RoomEntity dto)
        {
            return new Room()
            {
                Id = dto.Id,
                Name = dto.Name,
                Capacity = dto.Capacity
            };
        }

    }
}

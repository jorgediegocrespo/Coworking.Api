using Dicres.RepositoryService.Api.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;

namespace Coworking.Api.Mappers
{
    public class RoomMapper : IMapper<RoomModel, Room>
    {
        public Room Map(RoomModel dto)
        {
            return new Room()
            {
                Id = dto.Id,
                Name = dto.Name,
                Capacity = dto.Capacity
            };
        }

        public RoomModel Map(Room dto)
        {
            return new RoomModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Capacity = dto.Capacity
            };
        }
    }
}

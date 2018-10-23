using Dicres.RepositoryService.DataAccess.Contracts.Entities;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class Room2ServicesEntity : IBaseEntity
    {
        public int RoomId { get; set; }
        public int ServiceId { get; set; }

        public virtual RoomEntity Room { get; set; }
        public virtual ServiceEntity Service { get; set; }
    }
}

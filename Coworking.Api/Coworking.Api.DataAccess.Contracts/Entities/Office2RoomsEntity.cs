using Base.DataAccess.Contracts.Entities;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class Office2RoomsEntity : IBaseEntity
    {
        public int OfficeId { get; set; }
        public int RoomId { get; set; }

        public virtual OfficeEntity Office { get; set; }
        public virtual RoomEntity Room { get; set; }
    }
}

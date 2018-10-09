using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class RoomEntity : IBaseWithIdEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<Office2RoomsEntity> Office2Room { get; set; }
        public virtual ICollection<Room2ServicesEntity> Room2Service { get; set; }
    }
}

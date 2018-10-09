using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class ServiceEntity : IBaseWithIdEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Room2ServicesEntity> Room2Service { get; set; }
    }
}

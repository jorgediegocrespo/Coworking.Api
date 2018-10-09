using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class OfficeEntity : IBaseWithIdEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        public int AdminId { get; set; }
        public bool HasIndividualWorkSpace { get; set; }
        public int NumberWorkSpaces { get; set; }
        public decimal PriceWorkSpaceDaily { get; set; }
        public decimal PriceWorkSpaceMonthly { get; set; }

        public virtual AdminEntity Admin { get; set; }
        public virtual ICollection<Office2RoomsEntity> Office2Room { get; set; }
        public virtual BookingEntity Booking { get; set; }
    }
}

using System;
using Base.DataAccess.Contracts.Entities;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class UserEntity : IBaseWithIdEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual BookingEntity Booking { get; set; }
    }
}

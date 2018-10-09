using System;

namespace Coworking.Api.ViewModels
{
    public class BookingModel : BaseModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int OfficeId { get; set; }
        public bool RentWorkSpace { get; set; }
        public int? RoomId { get; set; }
    }
}

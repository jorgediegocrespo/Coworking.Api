using Coworking.Api.DataAccess.Contracts.Entities;
using Dicres.RepositoryService.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Coworking.Api.DataAccess.Contracts
{
    public interface ICoworkingDbContext : IDbContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<AdminEntity> Admins { get; set; }
        DbSet<BookingEntity> Bookings { get; set; }
        DbSet<OfficeEntity> Offices { get; set; }
        DbSet<Office2RoomsEntity> Offices2Rooms { get; set; }
        DbSet<Room2ServicesEntity> Rooms2Services { get; set; }
        DbSet<RoomEntity> Rooms { get; set; }
        DbSet<ServiceEntity> Services { get; set; }
    }
}

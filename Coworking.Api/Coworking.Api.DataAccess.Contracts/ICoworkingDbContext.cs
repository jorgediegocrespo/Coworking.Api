using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts
{
    public interface ICoworkingDbContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<AdminEntity> Admins { get; set; }
        DbSet<BookingEntity> Bookings { get; set; }
        DbSet<OfficeEntity> Offices { get; set; }
        DbSet<Office2RoomsEntity> Offices2Rooms { get; set; }
        DbSet<Room2ServicesEntity> Rooms2Services { get; set; }
        DbSet<RoomEntity> Rooms { get; set; }
        DbSet<ServiceEntity> Services { get; set; }
        DatabaseFacade Database { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
    }
}

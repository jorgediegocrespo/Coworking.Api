using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class BookingRepository : CoworkingRepository<BookingEntity>, IBookingRepository
    {
        protected override DbSet<BookingEntity> DbEntity
        {
            get { return _coworkingDbContext.Bookings; }
        }

        public BookingRepository(ICoworkingDbContext coworkingDbContext) : base(coworkingDbContext)
        {
        }

        public override async Task<BookingEntity> Get(int id)
        {
            return await _coworkingDbContext.Bookings
                .Include(x => x.Office)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override void UpdateEntityProperties(BookingEntity entityToUpdate, BookingEntity entity)
        {
            //Update all the properties you want change
            entityToUpdate.UserId = entity.UserId;
        }
    }
}

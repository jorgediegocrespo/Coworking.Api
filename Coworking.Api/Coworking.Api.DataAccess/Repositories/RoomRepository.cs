using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class RoomRepository : CoworkingRepository<RoomEntity>, IRoomRepository
    {
        protected override DbSet<RoomEntity> DbEntity
        {
            get { return _coworkingDbContext.Rooms; }
        }

        public RoomRepository(ICoworkingDbContext coworkingDbContext) : base(coworkingDbContext)
        {
        }

        public override async Task<RoomEntity> Get(int id)
        {
            return await _coworkingDbContext.Rooms
                .Include(x => x.Office2Room)
                .Include(x => x.Room2Service)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override void UpdateEntityProperties(RoomEntity entityToUpdate, RoomEntity entity)
        {
            //Update all the properties you want change
            entityToUpdate.Name = entity.Name;
        }
    }
}

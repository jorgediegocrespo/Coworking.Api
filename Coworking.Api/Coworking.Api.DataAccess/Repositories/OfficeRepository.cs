using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class OfficeRepository : BaseRepository<OfficeEntity>, IOfficeRepository
    {
        protected override DbSet<OfficeEntity> DbEntity
        {
            get { return _coworkingDbContext.Offices; }
        }

        public OfficeRepository(ICoworkingDbContext coworkingDbContext) : base(coworkingDbContext)
        {
        }

        public override async Task<OfficeEntity> Get(int id)
        {
            return await _coworkingDbContext.Offices
                .Include(x => x.Admin)
                .Include(x => x.Office2Room)
                .Include(x => x.Booking)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override void UpdateEntityProperties(OfficeEntity entityToUpdate, OfficeEntity entity)
        {
            //Update all the properties you want change
            entityToUpdate.Name = entity.Name;
        }
    }
}

using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class ServiceRepository : BaseRepository<ServiceEntity>, IServiceRepository
    {
        protected override DbSet<ServiceEntity> DbEntity
        {
            get { return _coworkingDbContext.Services; }
        }

        public ServiceRepository(ICoworkingDbContext coworkingDbContext) : base(coworkingDbContext)
        {
        }

        public override async Task<ServiceEntity> Get(int id)
        {
            return await _coworkingDbContext.Services
                .Include(x => x.Room2Service)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override void UpdateEntityProperties(ServiceEntity entityToUpdate, ServiceEntity entity)
        {
            //Update all the properties you want change
            entityToUpdate.Name = entity.Name;
        }
    }
}

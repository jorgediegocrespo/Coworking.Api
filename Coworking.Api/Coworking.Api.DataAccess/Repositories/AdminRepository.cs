using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class AdminRepository : CoworkingRepository<AdminEntity>, IAdminRepository
    {
        protected override DbSet<AdminEntity> DbEntity
        {
            get { return _coworkingDbContext.Admins; }
        }

        public AdminRepository(ICoworkingDbContext coworkingDbContext) : base(coworkingDbContext)
        {
        }

        public override async Task<AdminEntity> Get(int id)
        {
            return await _coworkingDbContext.Admins
                .Include(x => x.Office)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override void UpdateEntityProperties(AdminEntity entityToUpdate, AdminEntity entity)
        {
            //Update all the properties you want change
            entityToUpdate.Name = entity.Name;
        }
    }
}

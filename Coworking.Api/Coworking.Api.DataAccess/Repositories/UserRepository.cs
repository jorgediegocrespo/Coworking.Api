using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class UserRepository : CoworkingRepository<UserEntity>, IUserRepository
    {
        protected override DbSet<UserEntity> DbEntity
        {
            get { return _coworkingDbContext.Users; }
        }

        public UserRepository(ICoworkingDbContext coworkingDbContext) : base(coworkingDbContext)
        {
        }

        public override async Task<UserEntity> Get(int id)
        {
            return await _coworkingDbContext.Users
                .Include(x => x.Booking)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override void UpdateEntityProperties(UserEntity entityToUpdate, UserEntity entity)
        {
            //Update all the properties you want change
            entityToUpdate.Name = entity.Name;
        }
    }
}

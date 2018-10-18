using Base.DataAccess.Contracts.Entities;
using Base.DataAccess.Repositories;
using Coworking.Api.DataAccess.Contracts;

namespace Coworking.Api.DataAccess.Repositories
{
    public abstract class CoworkingRepository<T> : BaseRepository<T>
        where T : class, IBaseWithIdEntity
    {
        //CRUD
        protected ICoworkingDbContext _coworkingDbContext
        {
            get { return _dbContext as ICoworkingDbContext; }
        }

        public CoworkingRepository(ICoworkingDbContext coworkingDbContext) : base(coworkingDbContext) { }
    }
}

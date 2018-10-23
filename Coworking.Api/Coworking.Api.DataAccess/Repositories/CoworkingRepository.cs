using Coworking.Api.DataAccess.Contracts;
using Dicres.RepositoryService.DataAccess.Contracts.Entities;
using Dicres.RepositoryService.DataAccess.Repositories;

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

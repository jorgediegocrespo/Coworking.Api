using Dicres.RepositoryService.DataAccess.Contracts;
using Dicres.RepositoryService.DataAccess.Contracts.Entities;
using Dicres.RepositoryService.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dicres.RepositoryService.DataAccess.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : class, IBaseWithIdEntity
    {
        //CRUD
        protected readonly IDbContext _dbContext;

        protected abstract DbSet<T> DbEntity { get; }

        public BaseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            await DbEntity.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entityToRemove = await DbEntity.SingleAsync(x => x.Id == id);
            DbEntity.Remove(entityToRemove);
            await _dbContext.SaveChangesAsync();

            return;
        }

        public async Task<bool> Exists(int id)
        {
            return await DbEntity.AnyAsync(x => x.Id == id);
        }

        public virtual async Task<T> Get(int id)
        {
            return await DbEntity
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await DbEntity.ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            var entityToUpdate = await Get(entity.Id);

            UpdateEntityProperties(entityToUpdate, entity);

            var updateEntity = DbEntity.Update(entityToUpdate);
            await _dbContext.SaveChangesAsync();

            return entityToUpdate;
        }

        protected abstract void UpdateEntityProperties(T entityToUpdate, T entity);
    }
}

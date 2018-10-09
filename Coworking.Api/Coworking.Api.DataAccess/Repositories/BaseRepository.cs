using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : class, IBaseWithIdEntity
    {
        //CRUD
        protected readonly ICoworkingDbContext _coworkingDbContext;

        protected abstract DbSet<T> DbEntity { get; }

        public BaseRepository(ICoworkingDbContext coworkingDbContext)
        {
            _coworkingDbContext = coworkingDbContext;
        }

        public async Task<T> Add(T entity)
        {
            await DbEntity.AddAsync(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entityToRemove = await DbEntity.SingleAsync(x => x.Id == id);
            DbEntity.Remove(entityToRemove);
            await _coworkingDbContext.SaveChangesAsync();

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
            await _coworkingDbContext.SaveChangesAsync();

            return entityToUpdate;
        }

        protected abstract void UpdateEntityProperties(T entityToUpdate, T entity);
    }
}

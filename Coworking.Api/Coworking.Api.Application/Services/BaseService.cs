using Base.DataAccess.Contracts.Entities;
using Base.DataAccess.Contracts.Repositories;
using Coworking.Api.Application.Configuration;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Mappers;
using Coworking.Api.Business.Models;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Services
{
    public abstract class BaseService<T, R> : IBaseCrudService<T>
        where T : BaseBusinessModel
        where R : class, IBaseWithIdEntity
    {
        private readonly IRepository<R> _repository;
        private readonly IAppConfig _appConfig;
        private readonly IMapper<T, R> _mapper;

        public BaseService(IRepository<R> repository, IAppConfig appConfig, IMapper<T, R> mapper)
        {
            _repository = repository;
            _appConfig = appConfig;
            _mapper = mapper;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var maxTrys = _appConfig.MaxTrys;
            var timeToWait = TimeSpan.FromSeconds(_appConfig.SecondToWait);

            var retryPolity = Policy.Handle<Exception>().WaitAndRetryAsync(maxTrys, i => timeToWait);
            return await retryPolity.ExecuteAsync(
                async () =>
                {
                    var allEntities = await _repository.GetAll();
                    return allEntities.Select(o => _mapper.Map(o));
                });
        }

        public async Task<T> Get(int id)
        {
            var maxTrys = _appConfig.MaxTrys;
            var timeToWait = TimeSpan.FromSeconds(_appConfig.SecondToWait);

            var retryPolity = Policy.Handle<Exception>().WaitAndRetryAsync(maxTrys, i => timeToWait);
            return await retryPolity.ExecuteAsync(
                async () =>
                {
                    var entidad = await _repository.Get(id);
                    return _mapper.Map(entidad);
                });
        }

        public async Task<T> Add(T entity)
        {
            var maxTrys = _appConfig.MaxTrys;
            var timeToWait = TimeSpan.FromSeconds(_appConfig.SecondToWait);

            var retryPolity = Policy.Handle<Exception>().WaitAndRetryAsync(maxTrys, i => timeToWait);
            return await retryPolity.ExecuteAsync(
                async () =>
                {
                    var addedEntity = await _repository.Add(_mapper.Map(entity));
                    return _mapper.Map(addedEntity);
                });
        }

        public async Task<T> Update(T entity)
        {
            var maxTrys = _appConfig.MaxTrys;
            var timeToWait = TimeSpan.FromSeconds(_appConfig.SecondToWait);

            var retryPolity = Policy.Handle<Exception>().WaitAndRetryAsync(maxTrys, i => timeToWait);
            return await retryPolity.ExecuteAsync(
                async () =>
                {
                    var updatedEntity = await _repository.Update(_mapper.Map(entity));
                    return _mapper.Map(updatedEntity);
                });
        }

        public async Task<bool> Delete(int id)
        {
            var maxTrys = _appConfig.MaxTrys;
            var timeToWait = TimeSpan.FromSeconds(_appConfig.SecondToWait);

            var retryPolity = Policy.Handle<Exception>().WaitAndRetryAsync(maxTrys, i => timeToWait);
            return await retryPolity.ExecuteAsync(
                async () =>
                {
                    await _repository.DeleteAsync(id);
                    return true;
                });
        }
    }
}

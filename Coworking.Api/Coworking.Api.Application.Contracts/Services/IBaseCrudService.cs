using Coworking.Api.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
    public interface IBaseCrudService<T>
        where T : Base
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<bool> Delete(int id);
        Task<T> Update(T entity);
    }
}

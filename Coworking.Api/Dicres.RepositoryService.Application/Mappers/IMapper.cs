using Dicres.RepositoryService.Business.Models;

namespace Dicres.RepositoryService.Application.Mappers
{
    public interface IMapper<T, R>
        where T : BaseBusinessModel
        where R : class
    {
        T Map(R dto);
        R Map(T dto);
    }
}

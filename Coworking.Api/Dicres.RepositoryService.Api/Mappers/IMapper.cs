using Dicres.RepositoryService.Api.ViewModels;
using Dicres.RepositoryService.Business.Models;

namespace Dicres.RepositoryService.Api.Mappers
{
    public interface IMapper<T, R>
        where T : BaseModel
        where R : BaseBusinessModel
    {
        T Map(R dto);
        R Map(T dto);
    }
}

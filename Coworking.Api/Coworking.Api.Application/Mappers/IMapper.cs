using Coworking.Api.Business.Models;

namespace Coworking.Api.Application.Mappers
{
    public interface IMapper<T, R>
        where T : BaseBusinessModel
        where R : class
    {
        T Map(R dto);
        R Map(T dto);
    }
}

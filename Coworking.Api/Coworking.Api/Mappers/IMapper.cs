using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;

namespace Coworking.Api.Mappers
{
    public interface IMapper<T, R>
        where T : BaseModel
        where R : BaseBusinessModel
    {
        T Map(R dto);
        R Map(T dto);
    }
}

using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;

namespace Coworking.Api.Mappers
{
    public class ServiceMapper : IMapper<ServiceModel, Service>
    {
        public Service Map(ServiceModel dto)
        {
            return new Service()
            {
                Id = dto.Id,
                Name = dto.Name,
                Active = dto.Active,
                Price = dto.Price
            };
        }

        public ServiceModel Map(Service dto)
        {
            return new ServiceModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Active = dto.Active,
                Price = dto.Price
            };
        }
    }
}

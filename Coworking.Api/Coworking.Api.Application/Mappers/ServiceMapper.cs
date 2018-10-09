using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;

namespace Coworking.Api.Application.Mappers
{
    public class ServiceMapper : IMapper<Service, ServiceEntity>
    {
        public ServiceEntity Map(Service dto)
        {
            return new ServiceEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Active = dto.Active,
                Price = dto.Price
            };
        }

        public Service Map(ServiceEntity dto)
        {
            return new Service()
            {
                Id = dto.Id,
                Name = dto.Name,
                Active = dto.Active,
                Price = dto.Price
            };
        }

    }
}

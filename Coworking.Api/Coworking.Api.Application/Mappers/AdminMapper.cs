using Dicres.RepositoryService.Application.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;

namespace Coworking.Api.Application.Mappers
{
    public class AdminMapper : IMapper<Admin, AdminEntity>
    {
        public AdminEntity Map(Admin dto)
        {
            return new AdminEntity()
            {
                Email = dto.Email,
                Id = dto.Id,
                Name = dto.Name,
                Phone = dto.Phone,
            };
        }

        public Admin Map(AdminEntity dto)
        {
            return new Admin()
            {
                Email = dto.Email,
                Id = dto.Id,
                Name = dto.Name,
                Phone = dto.Phone,
            };
        }

    }
}

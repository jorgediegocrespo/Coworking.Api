using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;

namespace Coworking.Api.Mappers
{
    public class AdminMapper : IMapper<AdminModel, Admin>
    {
        public Admin Map(AdminModel dto)
        {
            return new Admin()
            {
                Email = dto.Email,
                Id = dto.Id,
                Name = dto.Name,
                Phone = dto.Phone,
            };
        }

        public AdminModel Map(Admin dto)
        {
            return new AdminModel()
            {
                Email = dto.Email,
                Id = dto.Id,
                Name = dto.Name,
                Phone = dto.Phone,
            };
        }
    }
}

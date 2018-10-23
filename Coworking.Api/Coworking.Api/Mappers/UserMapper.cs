using Dicres.RepositoryService.Api.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;

namespace Coworking.Api.Mappers
{
    public class UserMapper : IMapper<UserModel, User>
    {
        public User Map(UserModel dto)
        {
            return new User()
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                Active = dto.Active,
                CreateDate = dto.CreateDate
            };
        }

        public UserModel Map(User dto)
        {
            return new UserModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                Active = dto.Active,
                CreateDate = dto.CreateDate
            };
        }
    }
}

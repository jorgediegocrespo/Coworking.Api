using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;

namespace Coworking.Api.Application.Mappers
{
    public class UserMapper : IMapper<User, UserEntity>
    {
        public UserEntity Map(User dto)
        {
            return new UserEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                Active = dto.Active,
                CreateDate = dto.CreateDate
            };
        }

        public User Map(UserEntity dto)
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

    }
}

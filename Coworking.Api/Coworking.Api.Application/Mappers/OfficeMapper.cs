using Dicres.RepositoryService.Application.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;

namespace Coworking.Api.Application.Mappers
{
    public class OfficeMapper : IMapper<Office, OfficeEntity>
    {
        public OfficeEntity Map(Office dto)
        {
            return new OfficeEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Address = dto.Address,
                Phone = dto.Phone,
                City = dto.City,
                Active = dto.Active,
                AdminId = dto.AdminId,
                HasIndividualWorkSpace = dto.HasIndividualWorkSpace,
                NumberWorkSpaces = dto.NumberWorkSpaces,
                PriceWorkSpaceDaily = dto.PriceWorkSpaceDaily,
                PriceWorkSpaceMonthly = dto.PriceWorkSpaceMonthly
            };
        }

        public Office Map(OfficeEntity dto)
        {
            return new Office()
            {
                Id = dto.Id,
                Name = dto.Name,
                Address = dto.Address,
                Phone = dto.Phone,
                City = dto.City,
                Active = dto.Active,
                AdminId = dto.AdminId,
                HasIndividualWorkSpace = dto.HasIndividualWorkSpace,
                NumberWorkSpaces = dto.NumberWorkSpaces,
                PriceWorkSpaceDaily = dto.PriceWorkSpaceDaily,
                PriceWorkSpaceMonthly = dto.PriceWorkSpaceMonthly
            };
        }

    }
}

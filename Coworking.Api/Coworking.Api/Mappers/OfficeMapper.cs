using Dicres.RepositoryService.Api.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;

namespace Coworking.Api.Mappers
{
    public class OfficeMapper : IMapper<OfficeModel, Office>
    {
        public Office Map(OfficeModel dto)
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

        public OfficeModel Map(Office dto)
        {
            return new OfficeModel()
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

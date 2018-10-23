using Coworking.Api.DataAccess.Contracts.Entities;
using Dicres.RepositoryService.DataAccess.Contracts.Repositories;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IBookingRepository : IRepository<BookingEntity>
    {
    }
}

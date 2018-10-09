using Coworking.Api.Application.Configuration;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Mappers;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;

namespace Coworking.Api.Application.Services
{
    public class RoomService : BaseService<Room, RoomEntity>, IRoomService
    {
        public RoomService(IRoomRepository RoomRepository, IAppConfig appConfig)
            : base(RoomRepository, appConfig, new RoomMapper())
        { }
    }
}

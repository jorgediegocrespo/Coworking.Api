using Dicres.RepositoryService.Api.ViewModels;

namespace Coworking.Api.ViewModels
{
    public class RoomModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}

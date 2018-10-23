using Dicres.RepositoryService.Api.ViewModels;

namespace Coworking.Api.ViewModels
{
    public class ServiceModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
    }
}

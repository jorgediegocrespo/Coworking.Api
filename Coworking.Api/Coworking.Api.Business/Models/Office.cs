using Dicres.RepositoryService.Business.Models;

namespace Coworking.Api.Business.Models
{
    public class Office : BaseBusinessModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        public int AdminId { get; set; }
        public bool HasIndividualWorkSpace { get; set; }
        public int NumberWorkSpaces { get; set; }
        public decimal PriceWorkSpaceDaily { get; set; }
        public decimal PriceWorkSpaceMonthly { get; set; }
    }
}

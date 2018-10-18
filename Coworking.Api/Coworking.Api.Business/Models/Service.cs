namespace Coworking.Api.Business.Models
{
    public class Service : BaseBusinessModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
    }
}

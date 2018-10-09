namespace Coworking.Api.Business.Models
{
    public class Service : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
    }
}

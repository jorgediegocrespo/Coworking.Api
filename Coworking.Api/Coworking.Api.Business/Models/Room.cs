namespace Coworking.Api.Business.Models
{
    public class Room : BaseBusinessModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}

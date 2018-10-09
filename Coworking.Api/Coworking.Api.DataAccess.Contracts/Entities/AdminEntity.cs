namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class AdminEntity : IBaseWithIdEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual OfficeEntity Office { get; set; }
    }
}

namespace Base.DataAccess.Contracts.Entities
{
    public interface IBaseWithIdEntity : IBaseEntity
    {
        int Id { get; set; }
    }
}

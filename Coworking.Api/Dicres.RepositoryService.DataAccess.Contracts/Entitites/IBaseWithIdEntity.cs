namespace Dicres.RepositoryService.DataAccess.Contracts.Entities
{
    public interface IBaseWithIdEntity : IBaseEntity
    {
        int Id { get; set; }
    }
}

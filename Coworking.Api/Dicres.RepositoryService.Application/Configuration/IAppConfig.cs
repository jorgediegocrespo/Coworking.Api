namespace Dicres.RepositoryService.Application.Configuration
{
    public interface IAppConfig
    {
        int MaxTrys { get; }
        int SecondToWait { get; }
    }
}

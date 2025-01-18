namespace DotNetTutorial.DependencyInjection
{
    public interface ISingletonService
    {
        string toString();
        Guid GetId();
    }
}

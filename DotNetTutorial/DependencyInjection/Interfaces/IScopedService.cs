namespace DotNetTutorial.DependencyInjection
{
    public interface IScopedService 
    {
        string toString();
        Guid GetId();

    }
}

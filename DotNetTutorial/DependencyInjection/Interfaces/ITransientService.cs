namespace DotNetTutorial.DependencyInjection
{
    public interface ITransientService
    {
        string toString();
        Guid GetId();

    }
}

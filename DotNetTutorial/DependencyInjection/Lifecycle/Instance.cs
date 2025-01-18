namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public class Instance : IInstance
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}

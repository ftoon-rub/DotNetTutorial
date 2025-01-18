namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public abstract class Instance 
    {
        public abstract void AddCount();
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}

namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public class ScopedService : Instance /*, IScopedService*/
    {
        public override string Name { get; set; } = nameof(ScopedService);
        public ScopedService()
        {
            RequestCounter += 1;
        }
        
    }
}

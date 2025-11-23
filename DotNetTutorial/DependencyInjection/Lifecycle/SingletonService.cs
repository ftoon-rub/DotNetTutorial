namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public class SingletonService : Instance /*, ISingletonService*/
    {
        public override string Name { get; set; } = nameof(SingletonService);
        public SingletonService()
        {
            RequestCounter += 1;
        }
    }
}

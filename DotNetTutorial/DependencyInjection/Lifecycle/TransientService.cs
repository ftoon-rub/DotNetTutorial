
namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public class TransientService : Instance /*, ITransientService*/
    {
        public override string Name { get; set; } = nameof(TransientService);
        public TransientService()
        {
            RequestCounter += 1;
        }
    }
}

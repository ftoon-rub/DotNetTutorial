
namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public abstract class Instance : IInstance
    {
        public abstract string Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public static int RequestCounter { get; set; }
        public static int CallCounter { get; set; }
        public void AddCallCount()
        {
            CallCounter += 1;
        }
        public string ToString()
        {
            return $"Instance Name:{Name}, Id:{Id}, Call Counter:{CallCounter}, Request Counter:{RequestCounter}";
        }
    }
}

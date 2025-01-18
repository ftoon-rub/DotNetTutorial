namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public class SingletonService : Instance , ISingletonService
    {
        public SingletonService()
        {
            AddCount();
        }
        public static int counter { get; set; }
        public override void AddCount()
        {
            counter += 1;
        }

        public Guid GetId()
        {
            return this.Id;
        }
        public string toString()
        {
            return $"{nameof(SingletonService)}: counter:{SingletonService.counter} currentId:{this.Id}";
        }
    }
}

namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public class ScopedService : Instance , IScopedService
    {
        public ScopedService()
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
            return $"{nameof(ScopedService)}: counter:{ScopedService.counter} currentId:{this.Id}";
        }
    }
}

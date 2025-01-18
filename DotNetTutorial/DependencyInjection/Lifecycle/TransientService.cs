namespace DotNetTutorial.DependencyInjection.Lifecycle
{
    public class TransientService : Instance, ITransientService
    {
        public TransientService()
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
            return $"{nameof(TransientService)}: counter:{TransientService.counter} currentId:{this.Id}";
        }
    }
}

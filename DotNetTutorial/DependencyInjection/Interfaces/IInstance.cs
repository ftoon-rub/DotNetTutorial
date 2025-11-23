namespace DotNetTutorial.DependencyInjection
{
    public interface IInstance
    {
        string Name { get; set; }
        Guid Id { get; set; }
        static int RequestCounter { get; set; }
        static int CallCounter { get; set; }
        void AddCallCount();
        string ToString();
    }
}

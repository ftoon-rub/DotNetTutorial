using DotNetTutorial.DependencyInjection.Interfaces;

namespace DotNetTutorial.DependencyInjection.Services
{
    public class SecondCallServie : AbstractCallService, ISecondCallServie
    {
        private readonly IEnumerable<IInstance> _instances;

        public SecondCallServie(IEnumerable<IInstance> instances)
        {
            _instances = instances;
            AddRequestCounter();
        }

        protected override void AddRequestCounter()
        {
            _instances.ToList().ForEach(i => i.AddCallCount());
        }
    }
}

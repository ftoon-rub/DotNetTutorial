using DotNetTutorial.DependencyInjection.Interfaces;
using DotNetTutorial.DependencyInjection.Lifecycle;

namespace DotNetTutorial.DependencyInjection.Services
{
    public class FirstCallServie : AbstractCallService ,IFirstCallServie
    {
        private readonly IEnumerable<IInstance> _instances;
        private readonly ISecondCallServie _secondCallServie;

        public FirstCallServie(IEnumerable<IInstance> instances,ISecondCallServie secondCallServie)
        {
            _instances = instances;
            AddRequestCounter();

            _secondCallServie = secondCallServie;
        }

        protected override void AddRequestCounter()
        {
            _instances.ToList().ForEach(i => i.AddCallCount());
        }
    }
}

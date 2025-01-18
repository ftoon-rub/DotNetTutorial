using Microsoft.AspNetCore.Mvc;

namespace DotNetTutorial.DependencyInjection
{
    public interface INotificationService
    {
        void Notify();
        void NotifyMethodInjection([FromServices] IMessageService messageService);// Dependency injected
    }
}

using Microsoft.AspNetCore.Mvc;

namespace DotNetTutorial.DependencyInjection
{
    public interface INotificationService
    {
        void Notify();
        void NotifyFromServices([FromServices] IMessageService messageService);
    }
}

using Microsoft.AspNetCore.Mvc;

namespace DotNetTutorial.DependencyInjection
{
    public class NotificationService : INotificationService
    {
        /// <summary>
        /// Dependency Inversion Principle (DIP)
        /// </summary>
        private readonly IMessageService _messageService;

        /// <summary>
        /// Dependency Injection: Constructor Injection
        /// </summary>
        /// <param name="messageService"></param>
        public NotificationService(IMessageService messageService)// Dependency injected
        {
            _messageService = messageService;
        }
        public void Notify()
        {
            Console.WriteLine("Notify Dependency Injection Constructor Injection");
            _messageService.SendMessage();
        }

        /// <summary>
        /// Dependency Injection: Method Injection
        /// </summary>
        /// <param name="messageService"></param>
        public void NotifyFromServices([FromServices] IMessageService messageService)// Dependency injected
        {
            Console.WriteLine("NotifyFromServices Dependency Injection Method Injection");
            messageService.SendMessage();
        }
    }
}

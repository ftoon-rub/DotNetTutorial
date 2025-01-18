namespace DotNetTutorial.DependencyInjection
{
    public class NotificationService
    {
        private readonly IMessageService _messageService;

        public NotificationService(IMessageService messageService)
        {
            _messageService = messageService;
        }
    }
}

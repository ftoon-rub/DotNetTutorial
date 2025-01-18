namespace DotNetTutorial.DependencyInjection
{
    /// <summary>
    /// Dependency Inversion Principle: Low-level module SmsService (implements IMessageService abstraction)
    /// </summary>
    public class SmsService : IMessageService
    {
        public void SendMessage()
        {
            Console.WriteLine($"SMS sent");
        }
    }
}

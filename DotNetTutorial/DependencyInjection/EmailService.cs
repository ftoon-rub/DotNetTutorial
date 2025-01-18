namespace DotNetTutorial.DependencyInjection
{
    /// <summary>
    /// Low-level module: EmailService (implements IMessageService abstraction)
    /// </summary>
    public class EmailService : IMessageService
    {
        public void SendMessage()
        {
            Console.WriteLine($"Email sent");
        }
    }
}

namespace Desafio_SOLID.src
{
    public class EmailNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"sending Email: {message}");
        }
    }
}
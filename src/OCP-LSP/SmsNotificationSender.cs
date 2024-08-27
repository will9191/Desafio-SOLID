namespace Desafio_SOLID.src
{
    public class SmsNotificationSender : INotificationSender
    {
        public void SendNotification(string message){
            Console.WriteLine($"sending SMS: {message}");
        }
    }
}
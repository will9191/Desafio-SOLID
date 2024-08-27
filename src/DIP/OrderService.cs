namespace Desafio_SOLID.src
{
    public class OrderService
    {
        private readonly INotificationSender _notificationSender;
        private readonly IOrderReport _orderReport;

        public OrderService(INotificationSender notificationSender, IOrderReport orderReport)
        {
            _notificationSender = notificationSender;
            _orderReport = orderReport;
        }

        public void ProcessOrder(Order order)
        {
            _notificationSender.SendNotification($"your order #{order.Id} has been processed");
            _orderReport.GenerateOrderReport(order);
        }
    }
}
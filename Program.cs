using Desafio_SOLID.src;

namespace Desafio_SOLID;

class Program
{
    public static void Main()
    {
        var calculator = new PriceCalculator();
        var itemPrices = new List<double> { 100, 200, 150 };
        double totalPrice = calculator.CalculateTotalAmount(itemPrices);

        var order = new Order(1, totalPrice, "Willian Pereira");

        INotificationSender notificationSender = new EmailNotificationSender();
        IOrderReport orderReport = new OrderReportGenerator();

        var orderService = new OrderService(notificationSender, orderReport);
        orderService.ProcessOrder(order);
    }
}

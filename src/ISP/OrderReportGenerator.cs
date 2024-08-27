namespace Desafio_SOLID.src
{
    public class OrderReportGenerator : IOrderReport
    {
        public void GenerateOrderReport(Order order){
            Console.WriteLine($"order report for order: #{order.Id}");
            Console.WriteLine($"customer: {order.CustomerName}");
            Console.WriteLine($"total amount: ${order.TotalPrice}");
        }
    }
}
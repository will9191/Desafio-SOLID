namespace Desafio_SOLID.src
{
    public class OrderPrinter : IOrderPrinter
    {
        public void PrintOrder(Order order){
            Console.WriteLine($"printing order #{order.Id} for {order.CustomerName}");
        }
    }
}
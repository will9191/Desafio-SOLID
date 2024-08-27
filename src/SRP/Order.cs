namespace Desafio_SOLID.src;

// SRP
public class Order
{
    public int Id { get; set; }
    public double TotalPrice { get; set; }
    public string CustomerName { get; set; }

    public Order(int id, double totalPrice, string customerName)
    {
        Id = id;
        TotalPrice = totalPrice;
        CustomerName = customerName;
    }
}

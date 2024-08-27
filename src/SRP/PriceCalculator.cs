namespace Desafio_SOLID.src;

public class PriceCalculator
{
    public double CalculateTotalAmount(List<double> itemPrices)
    {
        double total = 0;
        foreach (var price in itemPrices)
        {
            total += price;
        }
        return total;
    }
}

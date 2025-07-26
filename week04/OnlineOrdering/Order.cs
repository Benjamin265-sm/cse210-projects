public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double sum = 0;
        foreach (var p in products)
        {
            sum += p.GetTotalCost();
        }
        double shipping = customer.LivesInUSA() ? 5 : 35;
        return sum + shipping;
    }

    public string GetPackingLabel()
    {
        var lines = new List<string>();
        foreach (var p in products)
        {
            lines.Add(p.GetPackingInfo());
        }
        return string.Join("\n", lines);
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
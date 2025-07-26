using System;

class Program
{
    static void Main(string[] args)
    {
        // Addresses & Customers
        var addr1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        var cust1 = new Customer("John Doe", addr1);

        var addr2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        var cust2 = new Customer("Jane Smith", addr2);

        // Orders
        var order1 = new Order(cust1);
        order1.AddProduct(new Product("Widget", "W123", 10.0, 2));
        order1.AddProduct(new Product("Gadget", "G456", 15.5, 1));

        var order2 = new Order(cust2);
        order2.AddProduct(new Product("Thingy", "T789", 7.25, 3));
        order2.AddProduct(new Product("Gizmo", "Z012", 12.0, 2));

        // Display
        DisplayOrder(order1);
        Console.WriteLine(new string('-', 30));
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order.CalculateTotalCost():0.00}");
    }
}
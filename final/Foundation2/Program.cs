using System;

class Program
{
    static void Main(string[] args)
    {
       // Create products
        Product product1 = new Product("Product 1", "P1", 10.0, 2);
        Product product2 = new Product("Product 2", "P2", 20.0, 3);
        Product product3 = new Product("Product 3", "P3", 15.0, 1);

        // Create address
        Address address = new Address("123 Street", "City", "State", "Country");

        // Create customers
        Customer customer1 = new Customer("John Doe", address);
        Customer customer2 = new Customer("Jane Smith", address);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}
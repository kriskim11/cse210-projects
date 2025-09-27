using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address and customer
        Address address1 = new Address("1345 Broadway", "Anahiem", "CA", "USA");
        Customer customer1 = new Customer("Billy Bob", address1);

        // Create products
        Product product1 = new Product("Bread", "B346", 3.0, 2);
        Product product2 = new Product("Milk", "M736", 2.5, 4);

        // Create order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display labels and total cost
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
    }
}
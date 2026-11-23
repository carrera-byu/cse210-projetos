using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Pedido 1 - USA
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A101", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "A102", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        // Pedido 2 - Fora dos USA
        Address address2 = new Address("Av. Paulista 1000", "Sao Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Maria Silva", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "B201", 75.00, 1));
        order2.AddProduct(new Product("Monitor", "B202", 250.00, 1));
        order2.AddProduct(new Product("Cable", "B203", 10.00, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
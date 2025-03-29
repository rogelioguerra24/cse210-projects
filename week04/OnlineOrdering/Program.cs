using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        //First Customer
        Address addressAurelio = new Address("123 Main St", "New York", "NY", "USA");
        Customer aurelioGuerra = new Customer("Aurelio Guerra", addressAurelio);

        //Second Customer
        Address addressGustavo = new Address("456 Elm Ave", "Toronto", "Ontario", "Canada");
        Customer gustavoSantalloa = new Customer("Gustavo Santalloa", addressGustavo);

        //Products
        Product product1 = new Product("Laptop", 101, 899.99m, 1);
        Product product2 = new Product("Wireless Mouse", 102, 24.50m, 2);
        Product product3 = new Product("Mechanical Keyboard", 103, 79.99m, 1);
        Product product4 = new Product("27-inch Monitor", 104, 299.99m, 1);

        //Order 1
        Order order1 = new Order(aurelioGuerra);
        order1.AddNewProducts(product1);
        order1.AddNewProducts(product4);
        order1.AddNewProducts(product2);

        Console.WriteLine(order1.GetDisplayOrder());

        //Order 2
        Order order2 = new Order(gustavoSantalloa);
        order2.AddNewProducts(product2);
        order2.AddNewProducts(product3);
        order2.AddNewProducts(product4);

        Console.WriteLine(order2.GetDisplayOrder());
    }
}
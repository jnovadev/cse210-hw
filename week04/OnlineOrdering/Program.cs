using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Maple Street", "Boise", "Idaho", "USA");
        Customer usaCustomer = new Customer("Emma Johnson", usaAddress);
        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(new Product("Laptop Stand", "LS-101", 29.99m, 1));
        usaOrder.AddProduct(new Product("Wireless Keyboard", "WK-202", 49.95m, 1));
        usaOrder.AddProduct(new Product("USB-C Cable", "UC-303", 9.99m, 2));

        Address internationalAddress = new Address("45 Avenida Central", "Santa Tecla", "La Libertad", "El Salvador");
        Customer internationalCustomer = new Customer("Carlos Ramirez", internationalAddress);
        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(new Product("Notebook", "NB-404", 4.50m, 3));
        internationalOrder.AddProduct(new Product("Blue Pen", "BP-505", 1.25m, 4));

        List<Order> orders = new List<Order> { usaOrder, internationalOrder };
        CultureInfo usCulture = CultureInfo.GetCultureInfo("en-US");

        for (int i = 0; i < orders.Count; i++)
        {
            Order order = orders[i];
            Console.WriteLine($"Order {i + 1}");
            Console.WriteLine("Packing label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine("Shipping label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total price: {order.GetTotalCost().ToString("C2", usCulture)} USD");
            Console.WriteLine();
        }
    }
}

using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("56 Jose Herrera Oropeza str", "Carora", "Lara 3050", "Venezuela");
        Customer customer1 = new Customer("Solis Lopez", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct("Google Pixel 8", "GP8O128", 499, 2);
        order1.AddProduct("Smart Watch Fitness Tracker", "SWFT247", 47.99, 3);
        order1.AddProduct("ASICS Men's Gel-Rocket 10 Indoor Court Shoes", "SICS10M", 64.95, 1);

        Address address2 = new Address("1007 Wabash Ave", "Linwood", "NJ 08221", "US");
        Customer customer2 = new Customer("Leo Grados", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct("Apple 2023 MacBook Pro Laptop M3 chip with 8‑core CPU", "A2023M3", 1230.61, 1);
        order2.AddProduct("Men Are from Mars, Women Are from Venus", "MMW-UPS", 13.94, 1);
        order2.AddProduct("Cornell Notes Notebook", "PANTPER", 15.99, 2);


        Console.WriteLine("Packing List:");
        order1.GetPackingLabel();
        Console.WriteLine(" - - - - - - - - - - - - - - - - - ");
        order1.GetShippingLabel();
        order1.GetTotalPrice();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Packing List:");
        order2.GetPackingLabel();
        Console.WriteLine(" - - - - - - - - - - - - - - - - - ");
        order2.GetShippingLabel();
        order2.GetTotalPrice();

    }
}
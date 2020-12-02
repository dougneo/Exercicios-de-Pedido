using System;
using S9V123.Entities.Enum;
using System.Globalization;
using S9V123.Entities;

namespace S9V123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
           
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
           
            Console.Write("Email: ");
            string email = Console.ReadLine();
           
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, email, birthdate);
           
            Console.WriteLine("Enter order data: ");
                                   
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{0} item data:", i);
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                OrderItem items = new OrderItem(quantity, price, product);

                order.AddItem(items);
            }

        }
    }
}

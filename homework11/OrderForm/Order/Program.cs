using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Goods goods3 = new Goods("orange", 3);
            Customer customer1 = new Customer("wang");
            Customer customer2 = new Customer("Li");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");

            order.AddOrderDetails(orderDetails);
            order.AddOrderDetails(orderDetails2);

            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            foreach (Order order1 in orderService.orderList)
            {
                Console.WriteLine(order1);
            }

            orderService.RemoveOrder("2");
            foreach (Order order1 in orderService.orderList)
            {
                Console.WriteLine(order1);
            }

            orderService.LookUpOrderById("1");

            orderService.AddOrder(order2);
            orderService.Export(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\s.xml");
            orderService.RemoveOrder("2");
            orderService.Import(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\s.xml");
        }
    }
}

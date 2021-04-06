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
            OrderDetails orderDetails = new OrderDetails();
            OrderDetails orderDetails2 = new OrderDetails();
            orderDetails.AddOrChangeItem(goods, 3);
            orderDetails.AddOrChangeItem(goods2, 4);
            orderDetails2.AddOrChangeItem(goods3, 5);
            Order order = new Order("wang", "Li", "wuhan", "1", orderDetails);
            Order order2 = new Order("tang", "hu", "WHU", "2", orderDetails2);

            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            foreach(Order order1 in orderService.orderList)
            {
                Console.WriteLine(order1);
            }

            orderService.RemoveOrder("2");
            foreach (Order order1 in orderService.orderList)
            {
                Console.WriteLine(order1);
            }

            orderService.LookUpOrderById("1");
        }
    }
}

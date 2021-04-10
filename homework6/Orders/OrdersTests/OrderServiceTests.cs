using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");
            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            List<Order> list = new List<Order>() { order, order2 };
            CollectionAssert.AreEqual(orderService.orderList, list);            //判断逻辑正确

            orderService.AddOrder(null);
            CollectionAssert.AreEqual(orderService.orderList, list);            //传入null
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");
            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            orderService.RemoveOrder("2");
            List<Order> list = new List<Order>() { order};
            CollectionAssert.AreEqual(orderService.orderList, list);        //判断逻辑正确

            orderService.RemoveOrder("2");
            CollectionAssert.AreEqual(orderService.orderList, list);        //删除一个不存在的订单

            orderService.RemoveOrder(null);
            CollectionAssert.AreEqual(orderService.orderList, list);        //删除null
        }

        [TestMethod()]
        public void LookUpOrderByIdTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");
            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            List<Order> list2 = orderService.LookUpOrderById("1");
            List<Order> list = new List<Order>() { order };
            CollectionAssert.AreEqual(list2, list);                 //逻辑正确

            List<Order> list3 = orderService.LookUpOrderById("3");
            List<Order> list4 = new List<Order>() { };
            CollectionAssert.AreEqual(list3, list4);            //查找一个没有的订单
        }

        [TestMethod()]
        public void LookUpOrderBySumCostTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");
            order.AddOrderDetails(orderDetails);
            order2.AddOrderDetails(orderDetails2);
            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            List<Order> list2 = orderService.LookUpOrderBySumCost(10.5);
            List<Order> list = new List<Order>() { order };
            CollectionAssert.AreEqual(list2, list);             //逻辑正确

            List<Order> list3 = orderService.LookUpOrderBySumCost(123);
            List<Order> list4 = new List<Order>() { };
            CollectionAssert.AreEqual(list3, list4);            //查找一个没有的订单
        }

        [TestMethod()]
        public void LookUpOrderByItemNameTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");
            order.AddOrderDetails(orderDetails);
            order.AddOrderDetails(orderDetails2);
            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            List<Order> list2 = orderService.LookUpOrderByItemName("apple");
            List<Order> list = new List<Order>() { order };
            CollectionAssert.AreEqual(list2, list);                 //逻辑正确

            List<Order> list3 = orderService.LookUpOrderByItemName("3");
            List<Order> list4 = new List<Order>() { };
            CollectionAssert.AreEqual(list3, list4);            //查找一个没有的订单
        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "1");
            orderService.AddOrder(order);
            orderService.ChangeOrder(order2);
            List<Order> list = new List<Order>() { order2 };
            CollectionAssert.AreEqual(orderService.orderList, list);            //逻辑正确

            Order order3 = new Order(customer2, "tang", "changsha", "2");
            orderService.ChangeOrder(order3);
            CollectionAssert.AreEqual(orderService.orderList, list);        //修改一个没有的订单号

        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");
            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            
            orderService.Export(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\s.xml");
            FileInfo fs = new FileInfo(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\s.xml");       //判断一个已存在的文件
            Assert.IsFalse(fs.Length == 0);
            
            orderService.Export(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\a.xml");
            FileInfo fs1 = new FileInfo(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\a.xml");      //判断一个不存在的文件
            Assert.IsFalse(fs1.Length == 0);
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Customer customer1 = new Customer("wang", "123");
            Customer customer2 = new Customer("Li", "234");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");
            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            
            orderService.Export(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\s.xml");
            orderService.RemoveOrder("2");                 

            List<Order> list2 = orderService.Import(@"D:\code\C#\RJGZJC_homework\homework5\Orders\Src\s.xml");
            List<Order> list = new List<Order>() { order,order2 };
            CollectionAssert.AreEqual(list, list2);     //导入已存在文件

        }
    }
}
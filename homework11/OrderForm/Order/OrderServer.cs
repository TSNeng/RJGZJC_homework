using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using OrderApp;

namespace Orders
{
    [Serializable]
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();   //当前所有的订单列表
        public List<Order> orders
        {
            get
            {
                using (var ctx = new OrderContext())
                {
                    return ctx.Orders.ToList<Order>();
                }
            }
        }

        public OrderService()
        {
            using (var ctx = new OrderContext())
            {
                if (ctx.Goods.Count() == 0)
                {
                    ctx.Goods.Add(new Goods("apple", 100.0));
                    ctx.Goods.Add(new Goods("egg", 200.0));
                    ctx.SaveChanges();
                }
                if (ctx.Customers.Count() == 0)
                {
                    ctx.Customers.Add(new Customer("li"));
                    ctx.Customers.Add(new Customer("zhang"));
                    ctx.SaveChanges();
                }
            }
        }

        public List<Order> AddOrder(Order order)
        {
            using (var db = new OrderContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return db.Orders.ToList();
            }
        }

        public void RemoveOrder(string id)          //根据id删除    
        {
            using (var ctx = new OrderContext())
            {
                var order = ctx.Orders.Include("Details").SingleOrDefault(o => o.id == o.id);
                if (order == null) return;
                ctx.OrderDetails.RemoveRange(order.Details);
                ctx.Orders.Remove(order);
                ctx.SaveChanges();
            } 
        }

        public List<Order> LookUpOrderById(string id)               //按照订单id查询，总金额排序
        {
                using (var db = new OrderContext())
                {
                    var _order = db.Orders.
                        Where(o => o.id == id)
                        .OrderBy(o => o.final_count);
                    return _order.ToList();
                }
        }


        public List<Order> LookUpOrderByItemName(string address)               //按照商品名称查询，总金额排序
        {
                using (var ctx = new OrderContext())
                {
                    var query = ctx.Orders
                        .Where(order => order.Details.Any(item => item.goods.itemName == address));
                    return query.ToList();
                }
         }

        public void ChangeOrder(Order order)
        {
            if (LookUpOrderById(order.id).Count() != 0)
            {
                RemoveOrder(order.id);
                orderList.Add(order);
            }

        }

        public List<Order> LookUpOrderBySumCost(double result) { return new List<Order>(); }

        public FileStream Export(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orderList);
                return fs;
            }
        }

        public List<Order> Import(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                    using (var ctx = new OrderContext())
                    {
                        List<Order> temp = (List<Order>)xmlSerializer.Deserialize(fs);
                        temp.ForEach(order => {
                            if (ctx.Orders.SingleOrDefault(o => o.id == order.id) == null)
                            {
                                ctx.Orders.Add(order);
                            }
                        });
                        ctx.SaveChanges();
                    }
                }
            return orderList;
        }
    }
}

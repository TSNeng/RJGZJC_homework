using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Orders
{
    [Serializable]
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();   //当前所有的订单列表

        public List<Order> AddOrder(Order order)
        {
            try
            {
                if (order != null) { orderList.Add(order); } 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return orderList;
        }

        public void RemoveOrder(string id)          //根据id删除    
        {
            try { 
            var _order = from s in orderList
                         where s.id == id
                         select s;
                if (_order.ToArray().Count() != 0) { orderList.Remove(_order.ToArray()[0]); } 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Order> LookUpOrderById(string id)               //按照订单id查询，总金额排序
        {
            var _order = from s in orderList
                         where s.id == id
                         orderby s.final_count
                         select s;
            return _order.ToList();
        }

        public List<Order> LookUpOrderBySumCost(double sum_cost)               //按照订单总金额查询，总金额排序
        {
            var _order = from s in orderList
                         where s.final_count == sum_cost
                         orderby s.final_count
                         select s;
            return _order.ToList();
        }

        public List<Order> LookUpOrderByItemName(string itemName)               //按照商品名称查询，总金额排序
        {
            var _order = from s in orderList
                         from details in s.orderDetails
                         where details.goods.itemName == itemName
                         orderby s.final_count
                         select s;
            return _order.ToList();
        }

        public void ChangeOrder(Order order)
        {
            if (LookUpOrderById(order.id).Count() != 0)
            {
                RemoveOrder(order.id);
                orderList.Add(order); 
            }

        }

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
            using(FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                List<Order> file_orders = (List<Order>)xmlSerializer.Deserialize(fs);
                foreach(Order order in file_orders)
                {
                    for(int i = 0; i < orderList.Count(); i++)
                    {
                        if (!order.Equals(orderList[i])) { orderList.Add(order); }
                    }
                }
            }
            return orderList;
        }
    }
}

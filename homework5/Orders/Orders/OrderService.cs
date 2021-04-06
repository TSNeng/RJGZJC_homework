using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class OrderService
    {
        public int count { get; set; }          //订单数
        public List<Order> orderList = new List<Order>();   //当前所有的订单列表

        public void AddOrder(Order order)
        {
            try 
                { orderList.Add(order); }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveOrder(string id)          //根据id删除    
        {
            try { 
            var _order = from s in orderList
                         where s.id == id
                         select s;
            orderList.Remove(_order.ToArray()[0]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void LookUpOrderById(string id)               //按照订单id查询，总金额排序
        {
            var _order = from s in orderList
                         where s.id == id
                         orderby s.orderDetails.sum_cost
                         select s;
            foreach(Order order in _order.ToArray())
            {
                Console.WriteLine(order);
            }
        }

        public void LookUpOrderBySumCost(double sum_cost)               //按照订单总金额查询，总金额排序
        {
            var _order = from s in orderList
                         where s.orderDetails.sum_cost == sum_cost
                         orderby s.orderDetails.sum_cost
                         select s;
            foreach (Order order in _order.ToArray())
            {
                Console.WriteLine(order);
            }
        }

        public void LookUpOrderByItemName(string itemName)               //按照商品名称查询，总金额排序
        {
            var _order = from s in orderList
                         from item in s.orderDetails.details.Keys
                         where item == itemName
                         orderby s.orderDetails.sum_cost
                         select s;
            foreach (Order order in _order.ToArray())
            {
                Console.WriteLine(order);
            }
        }

        public void ChangeOrder()
        {
            Console.WriteLine("请给出需要修改订单的订单号");
            string id = Console.ReadLine();
            var _order = from s in orderList
                         where s.id == id
                         select s;
            if(_order.Count() == 0) { Console.WriteLine("没有此订单"); return; }
            Order order = _order.ToArray()[0];
            Console.WriteLine("请给出需要修改的信息");
            string changeInfo = Console.ReadLine();
            var _info = from s in order.info.Keys
                        where s == changeInfo
                        select s;
            Console.WriteLine("原先的信息:{0}", order.info[_info.ToArray()[0]]);
            Console.WriteLine("需要将它修改成什么呢？");
            string changedInfo = Console.ReadLine();
            /*
            Type t = order.GetType();
            object obj = Activator.CreateInstance(t);
            FieldInfo fi = t.GetField(_info.ToArray()[0]);
            fi.SetValue(obj, changedInfo);
            */
            
            switch (_info.ToArray()[0])
            {
                case "receiver":
                    order.receiver = changedInfo;
                    order.info["receiver"] = changedInfo;
                    break;
                case "sender":
                    order.sender = changedInfo;
                    order.info["sender"] = changedInfo;
                    break;
                case "address":
                    order.address = changedInfo;
                    order.info["address"] = changedInfo;
                    break;
            }
        }

        
    }
}

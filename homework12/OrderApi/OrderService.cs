using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderApi
{

    public  class OrderService
    {
        private OrdingDBContext _context;

        public OrderService(OrdingDBContext context)
        {
            _context = context;
        }

        public  IEnumerable<Order> QueryAll()
        {
            
                return from o in _context.Orders.Include(o => o.Details)
                       orderby o.OrderAmount
                       select o;
        }

        public  Order GetOrder(int id)
        {

                return (from o in _context.Orders.Include(o => o.Details)
                       orderby o.OrderAmount
                       where o.OrderId == id
                       select o).FirstOrDefault();
        }


        public  bool AddOrder(Order order)
        {
                if (order == null || order.Details == null)
                    throw new ArgumentException("参数不能为null");
                //检查是否已经存在
                if (_context.Orders.Where(o => o.OrderId == order.OrderId).Any())
                {
                    return false;
                }

                _context.Orders.Add(order);
                _context.Entry(order).State = EntityState.Added;
                _context.SaveChanges();
                return true; 
        }

        public  void EditOrder(Order order)
        {
            if (order == null)
                throw new ArgumentException("参数不能为null");

                var currentOrder = _context.Orders.Include(o => o.Details).Where(o => o.OrderId == order.OrderId).FirstOrDefault();
                if (currentOrder == null)
                    throw new InvalidOperationException("要编辑的订单不存在！");


                if (!string.IsNullOrEmpty(order.CustomerName))
                    currentOrder.CustomerName = order.CustomerName;
                if (order.Details != null && order.Details.Count > 0)
                    currentOrder.Details = order.Details;
                if (order.OrderAmount > 0)
                    currentOrder.OrderAmount = order.OrderAmount;

                _context.Entry(currentOrder).State = EntityState.Modified;
                _context.SaveChanges(); 
            
        }

        public  void DeleteOrder(int orderId)
        {
                var currentOrder = _context.Orders.Include(o => o.Details).Where(o => o.OrderId == orderId).FirstOrDefault();
                if (currentOrder == null)
                    throw new InvalidOperationException("要删除的订单不存在！");

                _context.Orders.Remove(currentOrder);
                _context.SaveChanges(); 
            
        }

    }
}

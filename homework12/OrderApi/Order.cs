using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OrderApi
{
    [Serializable]
    public class Order
    {
        public Order()
        {
            OrderId = 0;
            Details = new List<OrderDetails>();
        }

        public Order(string productName, int productNum, string customerName, decimal orderAmount)
            : this(0, productName, productNum, customerName, orderAmount)
        {
        }

        public Order(string customerName, decimal orderAmount, params OrderDetails[] details)
            : this(0, customerName, orderAmount, details)
        {
        }
        public Order(int orderId, string productName, int productNum, string customerName, decimal orderAmount)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderAmount = orderAmount;
            Details = new List<OrderDetails>() { new OrderDetails(productName, productNum) };
        }

        public Order(int orderId, string customerName, decimal orderAmount, params OrderDetails[] details)
        {
            CustomerName = customerName;
            OrderAmount = orderAmount;
            OrderId = orderId;
            Details = new List<OrderDetails>(details);
        }

        public Order(Order o)
        {
            OrderId = o.OrderId;
            CustomerName = o.CustomerName;
            OrderAmount = o.OrderAmount;
            Details = o.Details.Select(od=>new OrderDetails(od)).ToList();
        }

        /// <summary>
        /// 订单号
        /// </summary>
        //[Key]
        public int OrderId { get; set; }
        /// <summary>
        /// 顾客名称
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 价格，是不是应该根据订单详情计算更好？
        /// 算了x偷懒
        /// </summary>
        public decimal OrderAmount { get; set; }
        public int DetailCount
        {
            get
            {
                return Details?.Count ?? 0;
            }
        }

        public List<OrderDetails> Details { get; set; }

        public override string ToString()
        {
            return $"订单号: {OrderId}, 订单价格: {OrderAmount}, 客户名称: {CustomerName}, 订单详情：[{string.Join<OrderDetails>(",", Details)}]";
        }


        public override int GetHashCode()
        {
            int hashCode = -1723691444;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
            hashCode = hashCode * -1521134295 + OrderAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(Details);
            return hashCode;
        }
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId &&
                   CustomerName == order.CustomerName &&
                   OrderAmount == order.OrderAmount &&
                   ((Details == null && order.Details == null) ||
                   ((Details != null && order.Details != null) &&
                   Enumerable.SequenceEqual(Details, order.Details)));

        }

    }
}

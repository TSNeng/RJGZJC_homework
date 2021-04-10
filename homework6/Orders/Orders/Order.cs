using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    [Serializable]
    public class Order
    {
        public Customer receiver;
        public string sender { get; set; }
        public string address { get; set; }
        public string id;
        public List<OrderDetails> orderDetails = new List<OrderDetails>();
        public double final_count{get;set;}
        //public Dictionary<string, string> info = new Dictionary<string, string>();

        public Order() { }

        public Order(Customer receiver, string sender, string address, string id)
        {
            this.receiver = receiver;
            this.sender = sender;
            this.address = address;
            this.id = id;
        }

        public void AddOrderDetails(OrderDetails Details)
        {
            orderDetails.Add(Details);
            final_count += Details.sum_cost;
        }

        public void RemoveDetails(OrderDetails details)
        {
            try
            {
                orderDetails.Remove(details);
                final_count -= details.sum_cost;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            string s = $"id:{id},receiver:{receiver},sender:{sender},address:{address}";
            orderDetails.ForEach(details => s += details);
            return s;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Customer>.Default.Equals(receiver, order.receiver) &&
                   sender == order.sender &&
                   address == order.address &&
                   id == order.id &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(orderDetails, order.orderDetails) &&
                   final_count == order.final_count;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(receiver, sender, address, id, orderDetails, final_count);
        }
    }
}

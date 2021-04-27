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
        public Customer receiver { get; set; } = new Customer();
        public string sender { get; set; }
        public string address { get; set; }
        public string id { get; set; }
        public List<OrderDetails> orderDetails = new List<OrderDetails>();
        public List<OrderDetails> Details { get { return orderDetails; } }
        public double final_count { get; set; } = 0;
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
            catch (Exception ex)
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
                   EqualityComparer<List<OrderDetails>>.Default.Equals(Details, order.Details) &&
                   final_count == order.final_count;
        }

        public override int GetHashCode()
        {
            int hashCode = -520075398;
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(receiver);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(sender);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(orderDetails);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(Details);
            hashCode = hashCode * -1521134295 + final_count.GetHashCode();
            return hashCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Order
    {
        public string receiver { get; set; }
        public string sender { get; set; }
        public string address { get; set; }
        public string id;
        public OrderDetails orderDetails;
        public Dictionary<string, string> info = new Dictionary<string, string>();

        public Order(string receiver, string sender, string address, string id,OrderDetails orderDetails)
        {
            this.receiver = receiver;
            this.sender = sender;
            this.address = address;
            Random random = new Random();
            this.id = id;
            info["id"] = this.id;
            info["receiver"] = this.receiver;
            info["sender"] = this.sender;
            info["address"] = this.address;
            this.orderDetails = orderDetails;
        }

        public override string ToString()
        {
            return $"id:{id},receiver:{receiver},sender:{sender},address:{address}.orderDetails:{orderDetails}";
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   receiver == order.receiver &&
                   sender == order.sender &&
                   address == order.address &&
                   id == order.id &&
                   EqualityComparer<Dictionary<string, string>>.Default.Equals(info, order.info);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(receiver, sender, address, id, info);
        }
    }
}

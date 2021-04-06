using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class OrderDetails
    {
        public double sum_cost { get; set; }
        public Dictionary<string,int> details;

        public OrderDetails()
        {
            details = new Dictionary<string, int>();
            sum_cost = 0;
        }

        public void AddOrChangeItem(Goods goods, int itemNum )
        {
            details.Add(goods.itemName, itemNum);
            sum_cost += itemNum * goods.price;
        }

        public void RemoveItem(Goods goods)
        {
            details.Remove(goods.itemName);
            sum_cost -= details[goods.itemName] * goods.price;
        }

        public override string ToString()
        {
            string s = " ";
            foreach(string key in details.Keys)
            {
                s += $" {key}:";
                s += details[key];
            }
            s += $" sum_cost:{sum_cost}";
            return s;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Dictionary<string, int>>.Default.Equals(this.details, details.details);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(details);
        }
    }
}

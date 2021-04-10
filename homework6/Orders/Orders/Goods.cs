using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    [Serializable]
    public class Goods
    {
        public string itemName;
        public double price;

        public Goods() { }
        public Goods(string itemName, double price)
        {
            this.itemName = itemName;
            this.price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   itemName == goods.itemName &&
                   price == goods.price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(itemName, price);
        }

        public override string ToString()
        {
            return $"itemName:{itemName},price:{price}";
        }
    }

    
}

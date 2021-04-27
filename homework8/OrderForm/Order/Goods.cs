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
        public string itemName { get; set; }
        public double price { get; set; }

        public Goods() { }
        public Goods(string itemName, double price)
        {
            this.itemName = itemName;
            this.price = price;
        }


        public override string ToString()
        {
            return $"itemName:{itemName},price:{price}";
        }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   itemName == goods.itemName &&
                   price == goods.price;
        }

        public override int GetHashCode()
        {
            int hashCode = 626095895;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(itemName);
            hashCode = hashCode * -1521134295 + price.GetHashCode();
            return hashCode;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    [Serializable]
    public class OrderDetails
    {
        public double sum_cost { get; set; }
        //public Dictionary<string,int> details;
        public Goods goods
        {
            get; set;
        }
        public int itemNum
        {
            get; set;
        }

        public OrderDetails() { }
        public OrderDetails(Goods goods_, int itemNum_)
        {
            //details = new Dictionary<string, int>();
            goods = goods_;
            itemNum = itemNum_;
            sum_cost = goods.price * itemNum;
        }

        public override string ToString()
        {
            return $"GoodsName:{goods.itemName} GoodsNum:{itemNum} SumCount:{sum_cost}";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   sum_cost == details.sum_cost &&
                   EqualityComparer<Goods>.Default.Equals(goods, details.goods) &&
                   itemNum == details.itemNum;
        }

        public override int GetHashCode()
        {
            int hashCode = -1429331697;
            hashCode = hashCode * -1521134295 + sum_cost.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + itemNum.GetHashCode();
            return hashCode;
        }
    }
}
